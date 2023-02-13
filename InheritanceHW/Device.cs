using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    abstract class Device
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Device(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public Device()
        {
            Name = null;
            Description = null;
        }
        public abstract bool Saund();
        public abstract string Show();
        public abstract string Desc();
    }
    class Kettle : Device
    {
        public Kettle()
        {
            Name = "Чайник";
            Description = "Чтобы делать чайочек :)";
        }
        public Kettle(string name, string description) : base(name, description)
        { }
        public override string Desc()
        {
            return Description;
        }

        public override bool Saund()
        {
            return true;
        }

        public override string Show()
        {
            return Name;
        }
    }
    class Microwave : Device
    {
        public Microwave()
        {
            Name = "Микроволновка";
            Description = "Чтобы делать горячие бутербродики :)";
        }
        public Microwave(string name, string description): base (name, description)
        { }
        public override string Desc()
        {
            return Description;
        }

        public override bool Saund()
        {
            return true;
        }

        public override string Show()
        {
            return Name;
        }
    }

    class Automobile : Device
    {
        public Automobile()
        {
            Name = "Машина";
            Description = "Чтобы катать свою п*пу :)";
        }
        public Automobile(string name, string description) : base(name, description)
        { }
        public override string Desc()
        {
            return Description;
        }

        public override bool Saund()
        {
            return true;
        }

        public override string Show()
        {
            return Name;
        }
    }

    class Steamer : Device
    {
        public Steamer()
        {
            Name = "Пороход";
            Description = "Чтобы плавать туда-сюда :)";
        }
        public Steamer(string name, string description) : base(name, description)
        { }
        public override string Desc()
        {
            return Description;
        }

        public override bool Saund()
        {
            return true;
        }

        public override string Show()
        {
            return Name;
        }
    }

}
