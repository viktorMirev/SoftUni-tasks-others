using System;

namespace OOPadv
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    class WeaponAttribute : Attribute
    {
        string author;
        int revision;
        string description;
        string[] reviewers;

        public WeaponAttribute(string author, int revision, string description, string[] reviewers)
        {
            this.author = author;
            this.revision = revision;
            this.description = description;
            this.reviewers = reviewers;
        }

        public string Author()
        {
            return "Author: " + this.author;
        }

        public string Revision()
        {
            return $"Revision: {this.revision}";
        }

        public string Description()
        {
            return "Class description: " + this.description;
        }

        public string Rewiewers()
        {
            return "Reviewers: " + string.Join(", ", this.reviewers);
        }
    }
}
