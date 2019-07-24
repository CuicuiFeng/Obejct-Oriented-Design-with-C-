//using System;
//using MySql.Data.MySqlClient;
//using System.Collections;
//using System.Configuration;
//using System.Data;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
//using FinalProject.Models;

//namespace FinalProject.DAL
//{
//    public class MysqlContext: IdentityDbContext<ApplicationUser>
//    {
//        public MysqlContext(DbContextOptions<MysqlContext> options) : base(options)
//        {
//            this.Database.EnsureCreated();
//        }

//        protected override void OnModelCreating(ModelBuilder builder)
//        {
//            base.OnModelCreating(builder);
//        }

//        public virtual DbSet<Book> books { get; set; }

//        //private static MySqlConnection cnc;
//        //private static MySqlCommand cmd;

//        //// connect to database
//        //public static void ConnectMysql(string sql)
//        //{

//        //    cnc = new MySqlConnection(sql);
//        //    try
//        //    {

//        //        Console.WriteLine("Connect to database successfully!");
//        //        cmd = new MySqlCommand();
//        //        cmd.Connection = cnc;
//        //    }
//        //    catch (Exception ex)
//        //    {

//        //        Console.WriteLine(ex);
//        //    }
//        //}

//        //// open database
//        //public static void OpenMysql()
//        //{

//        //    cnc.Open();
//        //}
//        //// close database
//        //public static void CloseMysql()
//        //{

//        //    cnc.Close();
//        //}

//        //// read the data
//        //public static void ReadMysql(string sql)
//        //{

//        //    cmd.CommandText = sql;
//        //    MySqlDataReader read = cmd.ExecuteReader();
//        //    while (read.Read())
//        //    {
//        //        if (read.HasRows)
//        //        {
//        //            Console.WriteLine(read.GetString(0) + ", " + read.GetString(1));
//        //        }
//        //    }
//        //}

//        //// operations
//        //public static void OperatorMysql(string sql)
//        //{

//        //    cmd.CommandText = sql;
//        //    if (cmd.ExecuteNonQuery() > 0)
//        //    {

//        //        Console.WriteLine("Operate Successufilly.");
//        //    }
//        //}

//        //class MainClass
//        //{
//        //    public static object MysqlTool { get; private set; }

//        //    public static void Main(string[] args)
//        //    {

//        //        // connect
//        //        MysqlTool.ConnectMysql("server=localhost;User Id=root;password=111111;Database=Student");
//        //        MysqlTool.OpenMysql();
//        //        // create table
//        //        MysqlTool.OperatorMysql("create table if not exists student (number int,age int)");
//        //        // insert data
//        //        MysqlTool.OperatorMysql("insert into student values(1,18)");
//        //        MysqlTool.OperatorMysql("insert into student values(2,19)");
//        //        MysqlTool.OperatorMysql("insert into student values(3,20)");

//        //        // read the data
//        //        MysqlTool.ReadMysql("select * from student");
//        //        MysqlTool.CloseMysql();
//        //    }
//        //}
//    }
//}
