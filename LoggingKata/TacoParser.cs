namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array.Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log that and return null
                logger.LogError("array length is less than 3", new System.Exception());
                // Do not fail if one record parsing fails, return null (completed)
                return null; // TODO Implement
            }

            // grab the latitude from your array at index 0
            // grab the longitude from your array at index 1
            // grab the name from your array at index 2(completed)
            var latitude = cells[0];
            var longitude = cells[1];
            var name = cells[2];
            // Your going to need to parse your string as a `double`
            // which is similar to parsing a string as an `int`(completed)
            var doubleLat = double.Parse(latitude);
            var doubleLon = double.Parse(longitude);
            // You'll need to create a TacoBell class
            // that conforms to ITrackable (completed)
            var point = new Point();
            point.Latitude = doubleLat;
            point.Longitude = doubleLon;

            // Then, you'll need an instance of the TacoBell class
            TacoBell tacoBell = new TacoBell();
            tacoBell.Name = name;
            tacoBell.Location = point;

            // With the name and point set correctly

            // Then, return the instance of your TacoBell class
            // Since it conforms to ITrackable (COMPLETED)

            return tacoBell;
        }
    }
}