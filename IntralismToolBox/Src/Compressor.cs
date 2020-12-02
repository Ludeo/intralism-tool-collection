using System.IO;
using System.IO.Compression;
using System.Text;

namespace IntralismToolBox
{
    /// <summary>
    ///     A class that contains functions for compressing and uncompressing files.
    /// </summary>
    public static class Compressor
    {
        /// <summary>
        ///     Compresses a string to bytes.
        /// </summary>
        /// <param name="str"> The input string that should be compressed. </param>
        /// <returns> The compressed bytes. </returns>
        public static byte[] Zip(string str)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(str!);

            using (MemoryStream msi = new (bytes))
            {
                using (MemoryStream mso = new ())
                {
                    using (GZipStream gs = new (mso, CompressionMode.Compress))
                    {
                        CopyTo(msi, gs);
                    }

                    return mso.ToArray();
                }
            }
        }

        /// <summary>
        ///     Uncompresses bytes to a string.
        /// </summary>
        /// <param name="bytes"> Bytes that should be uncompressed. </param>
        /// <returns> The uncompressed string. </returns>
        public static string Unzip(byte[] bytes)
        {
            using (MemoryStream msi = new (bytes!))
            {
                using (MemoryStream mso = new ())
                {
                    using (GZipStream gs = new (msi, CompressionMode.Decompress))
                    {
                        CopyTo(gs, mso);
                    }

                    return Encoding.UTF8.GetString(mso.ToArray());
                }
            }
        }

        private static void CopyTo(Stream src, Stream dest)
        {
            byte[] bytes = new byte[4096];

            int cnt;

            while ((cnt = src.Read(bytes, 0, bytes.Length)) != 0)
            {
                dest.Write(bytes, 0, cnt);
            }
        }
    }
}