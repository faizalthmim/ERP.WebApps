using Dapper;
using ERP.WebApps.Infrastructure.Base;
using ERP.WebApps.Infrastructure.EntityModels;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WebApps.Infrastructure.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(ERP_PROD_JSContext context) : base(context)
        { }

        public List<SYS_USER_MST> GetUser(string whereClause, string orderBy, int startRow, int lengthRow, out int totalRow)
        {
            var data = new List<SYS_USER_MST>();
            totalRow = 0;
            using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-2UG7991;Initial Catalog=SchoolDB;Integrated Security=true;"))
            {
                // Create the Command and Parameter objects.
                connection.Open();
                data = connection.Query<SYS_USER_MST>(
                    "dbo.usp_SYS_USER_MST",
                    new
                    {
                        vType = "GetPaged",
                        vWhereClause = whereClause,
                        vOrderBy = orderBy,
                        vStartRow = startRow,
                        vLengthRow = lengthRow
                    },
                    commandType: CommandType.StoredProcedure
                    ).ToList();
                // Get total Count 
                totalRow = connection.QuerySingle<int>(
                    "dbo.usp_SYS_USER_MST",
                    new
                    {
                        vType = "GetCount",
                        vWhereClause = whereClause,
                    },
                    commandType: CommandType.StoredProcedure
                    );
            }
            return data;
        }

        public SYS_USER_MST Insert(SYS_USER_MST param)
        {
            context.Add(param);
            context.SaveChanges();
            return param;
        }

        public SYS_USER_MST FindByID(string id)
        {
            var user = context.SYS_USER_MSTs.FirstOrDefault(m => m.USER_ID == id);
            return user;
        }
        public string Delete(SYS_USER_MST user)
        {
            context.Remove(user);
            context.SaveChanges();
            return user.USER_ID;
        }

    }
}
 