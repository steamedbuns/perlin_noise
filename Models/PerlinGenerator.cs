using System;
namespace BlazorApp.Models
{
    public class PerlinGenerator
    {
        private int m_width { get; set; }
        private int m_height { get; set; }
        private double m_segment { get; set; }
        private byte[] m_perlin_data { get; set; }

        public PerlinGenerator( int width, int height, double segment )
        {
            m_width = width;
            m_height = height;
            m_segment = segment;
            m_perlin_data = new byte[width * height];
        }

        public void GenerateNoise()
        {
            
        }

        private double ValueAtSample(double x, double y)
        {
            int x0 = (int)x;
            int y0 = (int)y;
            return 0.0;
        }
    }
}