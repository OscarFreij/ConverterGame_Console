using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterGame_Console
{
    public class Game
    {
        public RuleSet RuleSet { get; private set; }
    }

    public class RuleSet
    {
        public bool ab2 { get; set; }
        public bool ab8 { get; set; }
        public bool ab10 { get; set; }
        public bool ab16 { get; set; }
        public bool qb2 { get; set; }
        public bool qb8 { get; set; }
        public bool qb10 { get; set; }
        public bool qb16 { get; set; }
        public int questionCount { get; private set; }

        public RuleSet(bool ab2, bool ab8, bool ab10, bool ab16, bool qb2, bool qb8, bool qb10, bool qb16, int questionCount)
        {
            this.ab2 = ab2;
            this.ab8 = ab8;
            this.ab10 = ab10;
            this.ab16 = ab16;
            this.qb2 = qb2;
            this.qb8 = qb8;
            this.qb10 = qb10;
            this.qb16 = qb16;
            this.questionCount = questionCount;
        }

        public RuleSet(Defaults defaults)
        {
            switch (defaults)
            {
                case Defaults.Easy:
                    this.ab2 = false; 
                    this.ab8 = false;
                    this.ab10 = true;
                    this.ab16 = false;
                    this.qb2 = true;
                    this.qb8 = false;
                    this.qb10 = false;
                    this.qb16 = false;
                    this.questionCount = 5;
                    break;

                case Defaults.Medium:
                    this.ab2 = false;
                    this.ab8 = false;
                    this.ab10 = true;
                    this.ab16 = false;
                    this.qb2 = true;
                    this.qb8 = false;
                    this.qb10 = false;
                    this.qb16 = true;
                    this.questionCount = 10;
                    break;

                case Defaults.Hard:
                    this.ab2 = false;
                    this.ab8 = false;
                    this.ab10 = true;
                    this.ab16 = false;
                    this.qb2 = true;
                    this.qb8 = true;
                    this.qb10 = false;
                    this.qb16 = true;
                    this.questionCount = 15;
                    break;

                case Defaults.Sweet16:
                    this.ab2 = true;
                    this.ab8 = true;
                    this.ab10 = true;
                    this.ab16 = false;
                    this.qb2 = false;
                    this.qb8 = false;
                    this.qb10 = false;
                    this.qb16 = true;
                    this.questionCount = 16;
                    break;

                case Defaults.Bit2Byte:
                    this.ab2 = true;
                    this.ab8 = false;
                    this.ab10 = false;
                    this.ab16 = false;
                    this.qb2 = false;
                    this.qb8 = true;
                    this.qb10 = false;
                    this.qb16 = false;
                    this.questionCount = 8;
                    break;

                case Defaults.Mayhem:
                    this.ab2 = true;
                    this.ab8 = true;
                    this.ab10 = true;
                    this.ab16 = true;
                    this.qb2 = true;
                    this.qb8 = true;
                    this.qb10 = true;
                    this.qb16 = true;
                    this.questionCount = 20;
                    break;
            }
        }

        public enum Defaults
        {
            Easy = 0,
            Medium = 1,
            Hard = 2,
            Sweet16 = 3,
            Bit2Byte = 4,
            Mayhem = 5
        }
    }
}
