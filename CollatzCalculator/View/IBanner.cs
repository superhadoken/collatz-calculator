﻿namespace CollatzCalculator.View
{
    public interface IBanner
    {
        string RenderBanner();
    }

    public class Banner : IBanner
    {
        public string RenderBanner()
        {
            return @" 
         _____                  _____                      _   _     _              
        |_   _|                /  ___|                    | | | |   (_)             
          | |_   _ _ __   ___  \ `--.  ___  _ __ ___   ___| |_| |__  _ _ __   __ _  
          | | | | | '_ \ / _ \  `--. \/ _ \| '_ ` _ \ / _ \ __| '_ \| | '_ \ / _` | 
          | | |_| | |_) |  __/ /\__/ / (_) | | | | | |  __/ |_| | | | | | | | (_| | 
          \_/\__, | .__/ \___| \____/ \___/|_| |_| |_|\___|\__|_| |_|_|_| |_|\__, | 
              __/ | |                                                         __/ | 
             |___/|_|                                                        |___/  ";
        }
    }
}
