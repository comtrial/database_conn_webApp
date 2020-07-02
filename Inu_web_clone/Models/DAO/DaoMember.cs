using System;
using System.Collections.Generic;
using Inu_web_clone.Models.DTO;
using MySql.Data.MySqlClient;

namespace Inu_web_clone.Models.DAO
{
    public class DaoMember
    {
        //DB에 접근하여 데이터의 조작을 해주는
        //    Data Access Object

        internal InuDB _DB { get; set; }

        public DaoMember(InuDB db)
        {
            _DB = db;
        }
        public List<DtoMember> SelectAllMember()
        {
            List<DtoMember> lst = new List<DtoMember>();
            //모든 데이터의 입력이기 때문에 list로서의 dtomember들 반환


            using(MySqlConnection conn = _DB.Connection)
                //윈폼과는 다른 conn 연결 과정
            {
                conn.Open();
                
                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select *  from tb_member where nochool = 1";
                //db의 데이터들을 모두 받아오기 위한 cmd 작성 과정

                MySqlDataReader reader = cmd.ExecuteReader();
                //db의 데이터를 읽기위한 reader 객체 형성

                while(reader.Read())
                {
                    Console.WriteLine("================");
                    Console.WriteLine("{0} | {1} | {2} | {3} | {4} | {5} | {6} | {7}",
                        reader["id"].ToString(),
                        reader["title"].ToString(),
                        reader["author"].ToString(),
                        reader["e_mail"].ToString(),
                        reader["cnt"].ToString(),
                        reader["date"].ToString(),
                        reader["password"].ToString(),
                        reader["content"].ToString()
                        );
                    //컨솔 창에 정보 띄우기

                    DtoMember member = new DtoMember(
                        reader["id"].ToString(),
                        reader["title"].ToString(),
                        reader["author"].ToString(),
                        reader["e_mail"].ToString(),
                        Int32.Parse(reader["cnt"].ToString()),
                        reader["date"].ToString(),
                        reader["password"].ToString(),
                        reader["content"].ToString());
                    //이 프로젝트에서 사용할 수 있는 데이터로의 transfer을 위한 dto 생성자 호출

                    lst.Add(member);
                    //다수의 데이터 라인이기 때문에 list 로써의 할당
                }
                reader.Close();
                //리더가 계속 열러 있을경우 오류가 발생하기 때문에 닫아줘야함
            }
            return lst;
        }

        public void RegMember(DtoMember newMember)
        {
            using(MySqlConnection conn = _DB.Connection)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into tb_member(id, title, author, e_mail, cnt, date, password, content, nochool)" +
                    "values(@id, @title, @author, @e_mail, 0, @date, @password, @content, 1);";

                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);
                cmd.Parameters["@id"].Value = newMember.id;

                cmd.Parameters.Add("@title", MySqlDbType.VarChar, 100);
                cmd.Parameters["@title"].Value = newMember.title;

                cmd.Parameters.Add("@author", MySqlDbType.VarChar, 11);
                cmd.Parameters["@author"].Value = newMember.author;

                cmd.Parameters.Add("@e_mail", MySqlDbType.VarChar, 50);
                cmd.Parameters["@e_mail"].Value = newMember.e_mail;

                cmd.Parameters.Add("@date", MySqlDbType.VarChar, 50);
                cmd.Parameters["@date"].Value = newMember.date;

                cmd.Parameters.Add("@password", MySqlDbType.VarChar, 11);
                cmd.Parameters["@password"].Value = newMember.password;

                cmd.Parameters.Add("@content", MySqlDbType.VarChar, 100);
                cmd.Parameters["@content"].Value = newMember.content;

                //cnt 와 nochool 의 경우 기본값의 설정이기 때문에 기본값을 설

                Int32 rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine("RowAffected: {0}", rowsAffected);
            }
        }

        public DtoMember SelectOneMember(int id)
        {
            DtoMember selectedMember = null;
            
            using(MySqlConnection conn = _DB.Connection)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from tb_member where id = @id";

                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);
                cmd.Parameters["@id"].Value = id;

                MySqlDataReader reader = cmd.ExecuteReader();

                if (false == reader.Read())
                {
                    reader.Close();
                    return null;
                }

                    selectedMember = new DtoMember(
                    reader["id"].ToString(),
                    reader["title"].ToString(),
                    reader["author"].ToString(),
                    reader["e_mail"].ToString(),
                    Int32.Parse(reader["cnt"].ToString()),
                    reader["date"].ToString(),
                    reader["password"].ToString(),
                    reader["content"].ToString(),
                    Int32.Parse(reader["nochool"].ToString())
                    );
                //이 프로젝트에서 사용할 수 있는 데이터로의 transfer을 위한 dto 생성자 호출)

                reader.Close();
            }

            return selectedMember;
        }

        public void UpdateOneMember(DtoMember editMember)
        {
            if(editMember == null)
            {
                return;
            }

            using(MySqlConnection conn = _DB.Connection)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update tb_member set title = @title, author = @author, e_mail = @e_mail, cnt = @cnt, password = @password, content = @content WHERE id = @id;";


                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);
                cmd.Parameters["@id"].Value = editMember.id;

                cmd.Parameters.Add("@title", MySqlDbType.VarChar, 100);
                cmd.Parameters["@title"].Value = editMember.title;

                cmd.Parameters.Add("@author", MySqlDbType.VarChar, 11);
                cmd.Parameters["@author"].Value = editMember.author;

                cmd.Parameters.Add("@e_mail", MySqlDbType.VarChar, 50);
                cmd.Parameters["@e_mail"].Value = editMember.e_mail;

                cmd.Parameters.Add("@cnt", MySqlDbType.Int32, 11);
                cmd.Parameters["@cnt"].Value = editMember.cnt;

                cmd.Parameters.Add("@date", MySqlDbType.VarChar, 50);
                cmd.Parameters["@date"].Value = editMember.date;

                cmd.Parameters.Add("@password", MySqlDbType.VarChar, 11);
                cmd.Parameters["@password"].Value = editMember.password;

                cmd.Parameters.Add("@content", MySqlDbType.VarChar, 100);
                cmd.Parameters["@content"].Value = editMember.content;

                cmd.ExecuteNonQuery();
           
                return ;
            }

            
        }

        public void UpdateMemberNochool(int id)
        {
            using(MySqlConnection conn = _DB.Connection)
            {
                conn.Open();

                MySqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "update tb_member set nochool = 0 where id = @id;";

                cmd.Parameters.Add("@id", MySqlDbType.Int32, 11);
                cmd.Parameters["@id"].Value = id;

                cmd.ExecuteNonQuery();
               
                return ;
            }
        }
    }
}
