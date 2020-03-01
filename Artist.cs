namespace JsonData {
    public class Artist {
        public string ArtistName;
        public string RealName;
        public int Age;
        public string Hometown;
        public int GroupId;
        public Group Group;

        public override string ToString()
        {
            // return ArtistName + " " + Hometown;
            return $"{ArtistName}";
        }
    }
}  