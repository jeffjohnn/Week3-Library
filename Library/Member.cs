using System.Net.Sockets;

namespace Library
{
    class Member
    {
        private int memberId;
        private string name;
        private string address;
        private int phone;

        public int MemberID
        {
            get { return memberId; }
            private set { memberId = value; } // Private setter makes it read-only 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        // Constructor for new member
        public Member(int memberId, string name, string address, int phone)
        {
            this.memberId = memberId;
            this.name = name;
            this.address = address;
            this.phone = phone;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Member ID: {MemberID}");
            Console.WriteLine($"Member Name: {Name}");
            Console.WriteLine($"Member Address: {Address}");
            Console.WriteLine($"Member Phone No: {Phone}");
            Console.WriteLine();
        }
    }
}
