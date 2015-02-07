using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace D2VS.Patches
{
    public static class UpdateHash
    {
        public static readonly String PATCH_107 = "5022215415810790137230362291406216610136241";
        public static readonly String PATCH_108 = "186136541919916222724924812054497151134142";
        public static readonly String PATCH_109 = "86305915421012146669821464161172228182183";
        public static readonly String PATCH_110 = "2031601291921022355121815217519020515384176176";
        public static readonly String PATCH_111B = "10084163101148122234867213451951742912278";
        public static readonly String PATCH_112A = "13921514132472398914422474910113662487";
        public static readonly String PATCH_113C = "3193103205102414914720516111157237196176246";
        public static readonly String PATCH_113D = "751465661113981937751180886921925443237";

        public static readonly String[] HashArray = new String[] { PATCH_107, PATCH_108, PATCH_109, PATCH_110, PATCH_111B, PATCH_112A, PATCH_113C, PATCH_113D};

        public static bool isLegit(String fileName)
        {
            String fileHash = byteArrToString(checkMD5(fileName));

            foreach (var hash in HashArray)
                if (fileHash.Equals(hash))
                    return true;

            return false;
        }

        private static byte[] checkMD5(String filename)
        {
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return md5.ComputeHash(stream);
                }
            }
        }
        private static String byteArrToString(byte[] arr)
        {
            String ret = "";
            foreach (var b in arr)
                ret += b;

            return ret;
        }
    }
}
