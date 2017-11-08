namespace CollatzCalculator.View
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
              _____      _ _       _          _____      _            _       _             
             / ____|    | | |     | |        / ____|    | |          | |     | |            
            | |     ___ | | | __ _| |_ ____ | |     __ _| | ___ _   _| | __ _| |_ ___  _ __ 
            | |    / _ \| | |/ _` | __|_  / | |    / _` | |/ __| | | | |/ _` | __/ _ \| '__|
            | |___| (_) | | | (_| | |_ / /  | |___| (_| | | (__| |_| | | (_| | || (_) | |   
             \_____\___/|_|_|\__,_|\__/___|  \_____\__,_|_|\___|\__,_|_|\__,_|\__\___/|_|   
                                                                                Mo Mutlak - 2017";
        }
    }
}
