//// See https://aka.ms/new-console-template for more information
//using Microsoft.Data.SqlClient;

//try
//{

//    SqlConnection con = new SqlConnection();
//    string conStr = "Server = tcp:viya.database.windows.net,1433; Initial Catalog = employee; User Id =viya346; Password =Azurekaviya561;" + " Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
//    con.ConnectionString = conStr;
//    SqlCommand cmd = new SqlCommand("select * from employee");
//    cmd.Connection = con;
//    con.Open();
//    SqlDataReader srdr = cmd.ExecuteReader();
//    while (srdr.Read())
//    {
//        Console.WriteLine("ID \t" + srdr["Id"]);
//        Console.WriteLine("Fname \t" + srdr["Fname"]);
//        Console.WriteLine("Lname \t" + srdr["Lname"]);
//        Console.WriteLine("Designation \t" + srdr["Designation"]);
//        Console.WriteLine("Salary \t" + srdr["Salary"]);
//        Console.WriteLine("\n");
//    }
//    con.Close();
//}
//catch(Exception ex)
//{
//    Console.WriteLine("Error"+ex.Message);
//}
//finally
//{
//    Console.WriteLine("End of Program!!");
//    Console.ReadKey();
//}






// See https://aka.ms/new-console-template for more information
using Microsoft.Data.SqlClient;

try
{

    SqlConnection con = new SqlConnection();
    string conStr = "Server = tcp:viya.database.windows.net,1433; Initial Catalog = employee; User Id =viya346; Password =Azurekaviya561;" + " Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;";
    con.ConnectionString = conStr;
    SqlCommand cmd = new SqlCommand("usp_semployee")
    {

        Connection = con,
        CommandType = System.Data.CommandType.StoredProcedure
    };

    con.Open();
    SqlDataReader srdr = cmd.ExecuteReader();
    Console.WriteLine("employee ID\t First Name ");
    while (srdr.Read())
    {
        Console.WriteLine("ID \t" + srdr["Id"]);
        Console.WriteLine("Fname \t" + srdr["Fname"]);
        Console.WriteLine("Lname \t" + srdr["Lname"]);
        Console.WriteLine("Designation \t" + srdr["Designation"]);
        Console.WriteLine("Salary \t" + srdr["Salary"]);
        Console.WriteLine("\n");
    }
    con.Close();
}
catch (Exception ex)
{
    Console.WriteLine("Error" + ex.Message);
}
finally
{
    Console.WriteLine("End of Program!!");
    Console.ReadKey();
}




