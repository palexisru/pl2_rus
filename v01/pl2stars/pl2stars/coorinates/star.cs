using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using pl2.rainbow.stars.sky.components;

namespace pl2.rainbow.stars.coorinates
{
    public class Star
    {
        public readonly string name;
        float gloss;
        int ascension_hour;
        string ascension_hour_metric;
        int ascension_minutes;
        string ascension_minutes_metric;
        double ascension_seconds;
        string ascension_seconds_metric;
        int inducement_degrees;
        string inducement_degrees_metric;
        int inducement_minutes;
        string inducement_minutes_metric;
        double inducement_seconds;
        string inducement_seconds_metric;
        public readonly string constellation;
        string Greek;
        float sin_a;
        float cos_a;
        float sin_d;
        float cos_d;
        public float x;
        public float y;
        public float d;
        public bool visable;
        public Star(
                string p_name ,
                double p_gloss ,
                int p_ascension_hour ,
                string p_ascension_hour_metric ,
                int p_ascension_minutes ,
                string p_ascension_minutes_metric ,
                double p_ascension_seconds ,
                string p_ascension_seconds_metric ,
                int p_inducement_degrees ,
                string p_inducement_degrees_metric ,
                int p_inducement_minutes ,
                string p_inducement_minutes_metric ,
                double p_inducement_seconds ,
                string p_inducement_seconds_metric ,
                string p_constellation
        )
        {
            double ascension , inducement;
            name = p_name;
            gloss = (float)p_gloss;
            ascension_hour = p_ascension_hour;
            ascension_hour_metric = p_ascension_hour_metric;
            ascension_minutes = p_ascension_minutes;
            ascension_minutes_metric = p_ascension_minutes_metric;
            ascension_seconds = p_ascension_seconds;
            ascension_seconds_metric = p_ascension_seconds_metric;
            inducement_degrees = p_inducement_degrees;
            inducement_degrees_metric = p_inducement_degrees_metric;
            inducement_minutes = p_inducement_minutes;
            inducement_minutes_metric = p_inducement_minutes_metric;
            inducement_seconds = p_inducement_seconds;
            inducement_seconds_metric = p_inducement_seconds_metric;
            constellation = p_constellation;
            ascension = (ascension_hour + (ascension_minutes + ascension_seconds / 60.0) / 60.0) / 12 * Math.PI;
            inducement = Math.Sign( inducement_degrees ) *
                (Math.Abs( inducement_degrees ) + (inducement_minutes + inducement_seconds / 60.0) / 60.0) / 90.0;
            sin_a = (float)Math.Sin( inducement );
            cos_a = (float)Math.Cos( inducement );
            sin_d = (float)Math.Sin( ascension );
            cos_d = (float)Math.Cos( ascension );
        }

        public void CalcXY()
        {
            float t;
            float ct;
            float st;
            float sd;
            float cd;
            float cos_az;
            float sin_az;
            float cos_z;
            float sin_z;
            float r1;
            visable = false;
            st = Sky.sin_f * cos_a - Sky.cos_f * sin_a;
            ct = Sky.cos_f * cos_a + Sky.sin_f * sin_a;
            sd = sin_d;
            cd = cos_d;
            cos_z = Sky.sin_w * sin_d + Sky.cos_w * cos_d * Sky.cos_t;
            if (cos_z > 0)
            {
                sin_z = (float)Math.Sqrt( 1 - cos_z * cos_z );
                if (sin_z == 0)
                {
                    x = 0; y = 0;
                }
                else
                {
                    sin_az = cos_d * Sky.sin_t / sin_z;
                    cos_az = (-Sky.cos_w * sin_d + Sky.sin_w * cos_d * Sky.cos_t) / sin_z;
                    r1 = Sky.r0 * sin_z;
                    x = r1 * cos_az;
                    y = r1 * sin_az;
                }
                visable = true;
            }
        }

    }
}
