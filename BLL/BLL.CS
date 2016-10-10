using Marina.Entity;


namespace Marina.BLL
{
    class BLL
    {
        public object AddCustomer(Customer customer)
        {
            string sql = "select count(*) from Customer where PhoneNo='" + customer.phoneno + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }

        public object AddBoat(Boat eb,Customer ec)
        {
            string sql = "insert into boat values ('" + eb.Stateregistrationno + "'   ,   '" + eb.Manufacturer + "'   ,   " + eb.Length + "   ,   '" + eb.Customerphone + "'  , " + 0 + ",  '" + eb.Validity + "'   ,   " + eb.sail + "   ,   " + eb.keel + "   ,   '" + eb.type + "'    ,    '" + eb.energe + "')     INSERT INTO Customer VALUES ('" + ec .Name  + "','" + ec .Address  + "','" + ec .Phoneno  + "')";
            object count = DB.DAL.ExecuteScalar(sql);            
            return count;
        }
        public Customer FindCustomer(Customer a)
        {
            string sql = "select * from Customer,Boat where Customer.PhoneNo='" + a.Phoneno + "' and Boat.CustomerPhone=Customer.PhoneNo";
            Customer count = DB.DAL.ExecuteReader(sql); 
            return count;
        }
        public object AddSlipway(Slipway slipway)
        {
            string sql = "insert into slipway values ('" + slipway.Name + "'," + slipway.Volume + ")";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
        public object Update(Customer ec)
        {
            string sql = "update Customer set Address='" + ec.Address + "' where PhoneNo = '" + ec.Phoneno + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
        public object SlipwayManage_listbox2(object c)
        {
            string sql = "update boat set slipwayno = 0 where StateRegistrationNo = '" + c  + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
        public object SlipwayManage_listbox1(object c,object b)
        {
            string sql = "update boat set slipwayno = '" + c + "' where StateRegistrationNo = '" + b + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
        public System.Data.DataSet SlipwayManage_SS(object a)
        {
            string sql2 = "select StateRegistrationNo from boat where slipwayno = '" + a + "'";
            System.Data.DataSet ds2 = DB.DAL.ExecuteDataSet(sql2);
            return ds2;
        }
        public System.Data.DataSet SlipwayManage_BB()
        {
            string sql3 = "select StateRegistrationNo from boat where slipwayno = 0";
            System.Data.DataSet ds3 = DB.DAL.ExecuteDataSet(sql3);
            return ds3;
        }
        public System.Data.DataSet FindCustomer_Selecr()
        {
            string sql = "select * from Customer , Boat";
            System.Data.DataSet ds = DB.DAL.ExecuteDataSet(sql);
            return ds;
        }
        public object SlipwayMage_a(object x)
        {
            string sql = "select Volume from Slipway where id=  '" + x + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
        public object AddSlipWay_SS(object c)
        {
            string sql = "select count(*) from Slipway where Name='" + c + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
        public System.Data.DataSet SlipwayManage_Sx()
        {
            string sql = "select * from Slipway";
            System.Data.DataSet ds = DB.DAL.ExecuteDataSet(sql);
            return ds;
        }
        public object AddBoat_SS(Boat eb)
        {
            string sql = "select count(*) from Boat where Stateregistrationno='" + eb.Stateregistrationno + "'";
            object count = DB.DAL.ExecuteScalar(sql);
            return count;
        }
    }
}
