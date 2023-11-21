namespace Lesson28.Data
{
    public class SeedData
    {
        private Guid dotNetGroupId = Guid.Parse("b647a8f9-5b89-43e4-a1c8-1f6a202250d9");
        private Guid notJsGroupId = Guid.Parse("922119a5-e31e-43d2-863c-10a75d602891");
        EduCenterDB db = new EduCenterDB();
        public SeedData() 
        {
            //db.Database.EnsureCreated();
            db.Database.Migrate();
            AddGroup();
        }

        void AddGroup()
        {
            string donNetGroup = ".Net Group";
            string notJsGroup = "NodeJS";
            if (!db.Groups.Any(l => l.Name.Equals(donNetGroup)))
            {
                db.Add(new Group()
                {
                    GroupId = dotNetGroupId,
                    Name = donNetGroup
                });
            }

            if (!db.Groups.Any(l => l.Name.Equals(notJsGroup)))
            {
                db.Add(new Group()
                {
                    GroupId = notJsGroupId,
                    Name = notJsGroup
                });
            }
            db.SaveChanges();
        }
    }
}
