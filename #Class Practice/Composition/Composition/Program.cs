using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();
            Installer installer = new Installer(logger);
            DbMigrator dbMigrator = new DbMigrator(logger);
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
