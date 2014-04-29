using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace pl2.rainbow.stars.sky.components
{
    public partial class Sky : UserControl
    {
        public static float r0;
        public static float b0;
        public static float w0;
        public static float f0;
        public static float t;
        public static float w;
        public static float f;
        public static float sin_t;
        public static float cos_t;
        public static float sin_w;
        public static float cos_w;
        public static float sin_f;
        public static float cos_f;


        public Sky()
        {
            InitializeComponent();
        }

        public void Now()
        {
            f0 = (float)(10.0 / 12 * Math.PI);
            w0 = (float)(Math.PI / 3);
            r0 = (float)1000;
            b0 = (float)1.64;
        }
        public void Draw_nord()
        {
            f0 = 0f; 
            w0 = (float)(Math.PI) / 2; 
            r0 = 1000f; 
            b0 = 1.64f;
        }
        public void Draw_sourch()
        {
            f0 = 0f; 
            w0 = -(float)(Math.PI / 2 + 0.01); 
            r0 = 1000f; 
            b0 = 1.64f;

        }

        private void Sky_Paint(object sender , PaintEventArgs e)
        {
            Draw();
        }

        private void Draw (bool force){
            
int i;
string s;
double x1, x2;
   sin_f = Math.Sin(f0);
   cos_f = Math.Cos(f0);
   if (!force){
      // clear
/*
      LOCATE 1, 35
      PRINT "[ " + CHR$(27) + CHR$(26) + CHR$(24) + CHR$(25) + "+- ]";
      PRINT " вид  [ */ ] блеск  ";
*/
      x1 = f0 / Math.PI * 12;
      if (x1 < 0){ 
      //PRINT "-"; :
      x1 = -x1;

      }
      x2 = x1 - (int)x1;
      //PRINT LTRIM$(STR$(INT(x1))); "h"; LTRIM$(STR$(INT(x2 * 60))); "m ";
      x1 = w0 / Math.PI * 180;
      if (x1 > 180){ x1 = x1 - 360;}
      if (x1 < 0){ 
      //THEN PRINT "-"; :
       x1 = -x1;}
      x2 = x1 - (int)x1;

      //PRINT LTRIM$(STR$(INT(x1))); "°"; LTRIM$(STR$(INT(x2 * 60))); "'  ";
      //LOCATE 2, 35
      //PRINT "K - ";
      if( CoordFlag) {
         // PRINT "выкл";
      // ELSE
         // PRINT "вкл";
      }
      //PRINT " коорд  F - поиск  Esc - выход";
   }
   if ( CurStars != "   "){
      // LOCATE 2, 1
      // PRINT GetCSname$(CurStars);
      // LINE (-10, -15)-(10, 15), 1, B
   }else{
      // LINE (-10, -15)-(10, 15), 13, B
   }

   sin_w = Math.Sin(w0);
   cos_w = Math.Cos(w0);
   if( force){
      for( i = 1: i< StarCount; ++i){
         DrawStar (i);

         IF i MOD 37 = 0 THEN
            s = INKEY$
            IF s <> "" THEN GOTO done
         END IF
      NEXT i
   ELSE
      FOR i = 1 TO StarCount
         IF stars(i).v THEN
            DrawStar (i)
         END IF
         IF i MOD 37 = 0 THEN
            s = INKEY$
            IF s <> "" THEN GOTO done
         END IF
      NEXT i
   END IF
done:
   DrawSky$ = s

        }
    }

}
