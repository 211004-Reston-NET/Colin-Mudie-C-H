namespace HouseFunction {

    public class House  {

        private string owner;
        private string ghost;
        private int roomCount;

        public House()  {
            owner = "Colin";
            ghost = "Casper";
            roomCount = 1;
        }
        public string Owner { 
            get {
                return owner;
            } 
            set {
                owner = value;
            } 
        }
        public string MiceName { get; set; }

    }

}