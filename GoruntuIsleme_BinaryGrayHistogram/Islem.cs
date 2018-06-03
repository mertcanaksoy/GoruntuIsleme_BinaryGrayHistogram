using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoruntuIsleme_BinaryGrayHistogram
{
    class Islem
    {
        public static Image<Gray, byte> GriGetir(Image<Bgr, byte> img)
        {
            Image<Gray, byte> gri = img.Convert<Gray, byte>();
            return gri;
        }

        public static Mat HistogramGetir(Image<Gray, byte> griFoto)
        {
            DenseHistogram hist = new DenseHistogram(256, new RangeF(0, 256));
            hist.Calculate(new Image<Gray, Byte>[] { griFoto }, false, null);
            Mat m = new Mat();
            hist.CopyTo(m);
            return m;
        }

        public static Image<Gray, byte> BinaryGetir(Image<Gray, byte> gri)
        {
            int threshold = 70;
            Image<Gray, byte> binary = gri.ThresholdBinary(new Gray(threshold),
            new Gray(255));
            return binary;
        }

    }
}
