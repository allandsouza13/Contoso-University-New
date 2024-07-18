
namespace ContosoUniversity.Data
{
    public class SchoolContext
    {
        public object Students { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        internal async Task SaveChangesAsync()
        {
            throw new NotImplementedException();
        }
    }
}