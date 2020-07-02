using System;
namespace Inu_web_clone.Models.DTO
{
    //DB에 접근하여 가져온 데이터들을 프로젝트 내에서 가용가능한
    //    데이터로 반환 해주는 Data Transfer Object

    public class DtoMember
    {
        public String id;
        public String title;
        public String author;
        public String e_mail;
        public int cnt;
        public String date;
        public String password;
        public String content;
        public int nochool;

        public DtoMember(
           String id,
           String title,
           String author,
           String e_mail,
              int cnt,
           String date,
           String password,
           String content,
              int nochool
           )
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.e_mail = e_mail;
            this.cnt = cnt;
            this.date = date;
            this.password = password;
            this.content = content;
            this.nochool = nochool;
        }
        //모든 데이터의 반환

        public DtoMember(
           String id,
           String title,
           String author,
           String e_mail,
              int cnt,
           String date,
           String password,
           String content
           )
        {
            this.id = id;
            this.title = title;
            this.author = author;
            this.e_mail = e_mail;
            this.cnt = cnt;
            this.date = date;
            this.password = password;
            this.content = content;   
        }
        //nochool을 제외한 데이터 반환
    }     
}         
                  