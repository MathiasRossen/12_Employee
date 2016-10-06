namespace _12_Employee
{
    public class Employee
    {
        private int id;
        private string name;
        private string type;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public Employee(string name, string type, int id)
        {
            this.name = name;
            this.type = type;
            this.id = id;
        }

        public override string ToString()
        {
            return "ID=" + id + "_NAME=" + name + "_TYPE=" + type;
        }

        public override bool Equals(object obj)
        {
            if (obj.ToString() == ToString())
                return true;

            return false;
        }
    }
}