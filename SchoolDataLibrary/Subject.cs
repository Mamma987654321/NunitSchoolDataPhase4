namespace SchoolDataLibrary
{
    public class Subject
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public Subject(string name, int credits)
        {
            Name = name;
            Credits = credits;
        }
        public string GetSubjectInfo()
        {
            return $"{Name} has {Credits} credits";
        }
    }
}
