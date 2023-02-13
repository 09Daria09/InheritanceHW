using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceHW
{
    abstract class Musical_instrument
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string SoundInst { get; set; }
        public string Histpryinst { get; set; }

        public Musical_instrument(string name, string description, string sound, string history)
        {
            Name = name;
            Description = description;
            SoundInst = sound;
            Histpryinst = history;
        }
        public Musical_instrument()
        {
            Name = null;
            Description = null;
            SoundInst = null;
            Histpryinst = null;
        }
        public abstract string Saund();
        public abstract string Show();
        public abstract string Desc();
        public abstract string Histpry();

    }
    class Violin : Musical_instrument
    {
        public Violin():base()
        {
            Name = "Скрипка";
        }
        public Violin(string name, string description, string sound, string history):base(name, description, sound, history)
        {
            Name = name;
            Description = description;
            SoundInst = sound;
            Histpryinst = history;
        }
        public override string Desc()
        {
            Console.Write($"Введите описание {Name} -> ");
            Description = Console.ReadLine();

            return Description;
        }

        public override string Histpry()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            Histpryinst = Console.ReadLine();

            return Histpryinst;
        }
        public override string Saund()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            SoundInst = Console.ReadLine();

            return SoundInst;
        }
        public override string Show()
        {
            return Name;
        }
    }
    class Trombone : Musical_instrument
    {
        public Trombone() : base()
        {
            Name = "Тромбон";
        }
        public Trombone(string name, string description, string sound, string history) : base(name, description, sound, history)
        {
            Name = name;
            Description = description;
            SoundInst = sound;
            Histpryinst = history;
        }
        public override string Desc()
        {
            Console.Write($"Введите описание {Name} -> ");
            Description = Console.ReadLine();

            return Description;
        }

        public override string Histpry()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            Histpryinst = Console.ReadLine();

            return Histpryinst;
        }
        public override string Saund()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            SoundInst = Console.ReadLine();

            return SoundInst;
        }
        public override string Show()
        {
            return Name;
        }
    }
    class Ukulele : Musical_instrument
    {
        public Ukulele() : base()
        {
            Name = "Укулеле";
        }
        public Ukulele(string name, string description, string sound, string history) : base(name, description, sound, history)
        {
            Name = name;
            Description = description;
            SoundInst = sound;
            Histpryinst = history;
        }
        public override string Desc()
        {
            Console.Write($"Введите описание {Name} -> ");
            Description = Console.ReadLine();

            return Description;
        }

        public override string Histpry()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            Histpryinst = Console.ReadLine();

            return Histpryinst;
        }
        public override string Saund()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            SoundInst = Console.ReadLine();

            return SoundInst;
        }
        public override string Show()
        {
            return Name;
        }
    }
    class Cello : Musical_instrument
    {
        public Cello() : base()
        {
            Name = "Укулеле";
        }
        public Cello(string name, string description, string sound, string history) : base(name, description, sound, history)
        {
            Name = name;
            Description = description;
            SoundInst = sound;
            Histpryinst = history;
        }
        public override string Desc()
        {
            Console.Write($"Введите описание {Name} -> ");
            Description = Console.ReadLine();

            return Description;
        }

        public override string Histpry()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            Histpryinst = Console.ReadLine();

            return Histpryinst;
        }
        public override string Saund()
        {
            Console.Write($"Введите историю создания {Name} -> ");
            SoundInst = Console.ReadLine();

            return SoundInst;
        }
        public override string Show()
        {
            return Name;
        }
    }
}
