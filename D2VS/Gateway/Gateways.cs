using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace D2VS.Gateway
{
    public class Gateways
    {
        public List<Gate> Gates = new List<Gate>();
        private List<string> reg = new List<string>();
        public Gateways()
        {
            this.reg = LoadRegistry();
            loadGates();
        }

        private void loadGates()
        {
            if(this.reg.Count>0)
                for(int i=2; i<this.reg.Count-1; i+=3)
                    Gates.Add(new Gate(this.reg[i + 2], this.reg[i], this.reg[i + 1]));
        }

        public void Add(Gate gateway)
        {
            if (!gateExists(gateway.name, gateway.ip, gateway.timezone))
            {
                this.Gates.Add(gateway);

                this.reg.Add(gateway.ip);
                this.reg.Add(gateway.timezone);
                this.reg.Add(gateway.name);
            }
        }

        public void Apply()
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "\\software\\Battle.net\\Configuration\\";
            const string keyName = userRoot + subkey;
            const string valKey = "Diablo II Battle.net gateways";
            String key = "";

            for(int i=0; i<this.reg.Count; i++)
            {
                if (i == (this.reg.Count - 1))
                    key += this.reg[i];
                else
                    key += this.reg[i] + '\n';

            }

            Registry.SetValue(keyName, valKey, key.Split('\n'));
        }

        private int regStrSearch(string value)
        {
            for (int i = 0; i < this.reg.Count; i++)
                if (this.reg[i].Equals(value))
                    return i;

            return -1;
        }

        public bool gateRemove(String name, String ip, bool registryRemove)
        {
            if(IndexOfGate(name, ip)>-1)
            {
                Gates.RemoveAt(IndexOfGate(name, ip));
                if(registryRemove)
                {
                    int indexToRemove = regStrSearch(ip);
                    for(int i=0;i<3;i++)
                        this.reg.RemoveAt(indexToRemove); // Position will update with removing elements

                    Apply();    // apply this.reg as registry key
                }
                
                return true;
            }

            return false;
        }

        public bool gateRemove(String name, String ip, String timezone, bool registryRemove)
        {
            if (IndexOfGate(name, ip, timezone) > -1)
            {
                Gates.RemoveAt(IndexOfGate(name, ip, timezone));
                if (registryRemove)
                {
                    int indexToRemove = regStrSearch(ip);
                    for (int i = 0; i < 3; i++)
                        this.reg.RemoveAt(indexToRemove); // Position will update with removing elements

                    Apply();    // apply this.reg as registry key
                }
                return true;
            }

            return false;
        }
        public bool gateRemove(Gate gate, bool registryRemove)
        {
            if(IndexOfGate(gate)>-1)
            {
                Gates.RemoveAt(IndexOfGate(gate));
                if (registryRemove)
                {
                    int indexToRemove = regStrSearch(gate.ip);
                    for (int i = 0; i < 3; i++)
                        this.reg.RemoveAt(indexToRemove); // Position will update with removing elements

                    Apply();    // apply this.reg as registry key
                }
                return true;
            }
            return false;
        }
        private List<string> LoadRegistry()
        {
            const string userRoot = "HKEY_CURRENT_USER";
            const string subkey = "\\software\\Battle.net\\Configuration\\";
            const string keyName = userRoot + subkey;
            const string valKey = "Diablo II Battle.net gateways";
            object ret = Registry.GetValue(keyName, valKey, 0);
            string[] vals = (string[])ret;
            List<string> reg = new List<string>(vals);

            return reg;
        }

        public int IndexOfGate(String name)
        {
            for (int i = 0; i < Gates.Count; i++)
                if (Gates[i].name.Equals(name))
                    return i;

            return -1;
        }
        public int IndexOfGate(String name, String ip)
        {
            for (int i = 0; i < Gates.Count; i++)
                if (Gates[i].name.Equals(name) && Gates[i].ip.Equals(ip))
                    return i;

            return -1;
        }
        public int IndexOfGate(String name, String ip, String timezone)
        {
            for (int i = 0; i < Gates.Count; i++)
                if (Gates[i].name.Equals(name) && Gates[i].ip.Equals(ip) && Gates[i].timezone.Equals(timezone))
                    return i;

            return -1;
        }

        public int IndexOfGate(Gate gate)
        {
            for (int i = 0; i < Gates.Count; i++)
                if (Gates[i].GetHashCode().Equals(gate.GetHashCode()))
                    return i;

            return -1;
        }
        private bool gateExists(String name, String ip, String timezone)
        {
            foreach (var g in Gates)
                if (g.name.Equals(name) && g.ip.Equals(ip) && g.timezone.Equals(timezone))
                    return true;

            return false;
        }
        private bool gateExists(String name, String ip)
        {
            foreach (var g in Gates)
                if (g.name.Equals(name) && g.ip.Equals(ip))
                    return true;

            return false;
        }
        public override string ToString()
        {
            String key = "";

            foreach (var s in this.reg)
                key += s + '\n';

            return key;
        }

    }
}
