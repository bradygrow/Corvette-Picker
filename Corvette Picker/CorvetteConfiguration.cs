using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corvette_Picker
{
    class CorvetteConfiguration
    {
        static int BASE_PRICE = 67495;
        static int RED_COLOR_PRICE = 995;
        static int SECOND_TRIM_PRICE = 6800;
        static int FLS_PRICE = 1495;
        static int SPOILER_PRICE = 1150;
        static int LOGO_PRICE = 345;
        static int FLOORMAT_PRICE = 235;
        int price = 0;
        int trim = 1;
        Boolean FLS = false;
        Boolean floormats = false;
        Boolean logo = false;
        Boolean spoiler = false;
        String top = "u";
        String color = "w";

        public CorvetteConfiguration()
        {
            
        }

        public int calcPrice()
        {
            price = BASE_PRICE;
            if (trim == 2)
            {
                price += SECOND_TRIM_PRICE;
            }
            else if (trim == 1)
            {

            }

            if (color == "w")
            {


            }
            else if (color == "r")
            {
                price += RED_COLOR_PRICE;
            }

            if (floormats)
            {
                price += FLOORMAT_PRICE;
            }
            if (logo)
            {

                price += LOGO_PRICE;
            }
            if (FLS)
            {
                price += FLS_PRICE;
            }
            if (spoiler)
            {
                price += SPOILER_PRICE;
            }

            return price;
        }

        public String changePicture()
        {
            if (color == "w")
            { //color is WHITE
                if (spoiler)
                {// white and spoiler
                    if (top == "down")
                    { //white, spoiler,  ROOF OPEN
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.down.wing.bmp";
                    }
                    else
                    { //white, spoiler,  ROOF CLOSED
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.up.wing.bmp";
                    }
                }
                else if (!spoiler)
                {//white & no spoiler
                    if (top == "down")
                    { //white, no spoiler,  ROOF OPEN
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.down.bmp";
                    }
                    else
                    { //white, no spoiler,ROOF CLOSED
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.white.top.up.bmp";
                    }
                }
            }
            else if (color == "r")
            { //color is RED
                if (spoiler)
                { //red & spoiler
                    if (top == "down")
                    { //red,  spoiler,  ROOF OPEN
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.down.wing.bmp";
                    }
                    else
                    { //red,  spoiler, ROOF CLOSED
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.up.wing.bmp";
                    }
                }
                else if (!spoiler)
                {//red & no spoiler
                    if (top == "down")
                    { //red,  no spoiler,  ROOF OPEN
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.down.bmp";
                    }
                    else
                    { //red, no spoiler,ROOF CLOSED
                        return "http://itec-web-dev04.radford.edu/ews/corvette/corvette.red.top.up.bmp";
                    }
                }
            }
            return "";
        }

        public int getBasePrice()
        {
            return BASE_PRICE;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public void setTop(string top)
        {
            this.top = top;
        }

        public void setTrim(int trim)
        {
            this.trim = trim;
        }

        public int getTrim()
        {
            return trim;
        }

        public void setFLS(Boolean FLS)
        {
            this.FLS = FLS;
        }
        public void setSpoiler(Boolean spoiler)
        {
            this.spoiler = spoiler;
        }
        public void setLogo(Boolean logo)
        {
            this.logo = logo;
        }
        public void setfloormats(Boolean floormats)
        {
            this.floormats = floormats;
        }
        public Boolean getFLS()
        {
            return FLS;
        }
    }
}
