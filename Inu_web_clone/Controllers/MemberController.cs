using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Inu_web_clone.Models;
using Inu_web_clone.Models.DAO;
using Inu_web_clone.Models.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Inu_web_clone.Controllers
{
    public class MemberController : Controller
    {
        private readonly ILogger<MemberController> _logger;
        private readonly InuDB _db;
        public MemberController(ILogger<MemberController> logger, InuDB db)
        {
            _logger = logger;
            _db = db;
        }
        // GET: /<controller>/
        public IActionResult Member()
        {
            DaoMember dao = new DaoMember(_db);
            //db conn을 파라미터로 전달하기 위한 dao 생성자 호출

            return View(dao.SelectAllMember());
        }

        public IActionResult NewMember()
        {
            return View();
        }

        public IActionResult RegMember(
           string id,
           string title,
           string author,
           string e_mail,
           string password,
           string content)
        {
            DaoMember dao = new DaoMember(_db);
            //dao 객체 연결을 위함

            
            try
            {
                DateTime dtnow = DateTime.Now;
                //현재시간을 가져오는 코드

                DtoMember newMember = new DtoMember(
                id,
                title,
                author,
                e_mail,
                0, //기본값
                dtnow.ToString("yyyyMMddHHmmss"), //현재시간 데이터의 표현
                password,
                content,
                1 /*기본값*/);
                //newmember에서 받아온 내용을 dto를 통해 transfer 해와서 newmember를 형성

                dao.RegMember(newMember);
                //형성된 newmember를 dao에 전달하여 데이터의 추

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Member");
            //데이터의 입력이 되었는지의 확인을 위해 다시 member페이지로의 이동
        }

        public IActionResult EditMember(string id)
        {
            DaoMember dao = new DaoMember(_db);
            //dao 객체 연결을 위함

            return View(dao.SelectOneMember(Int32.Parse(id)));
        }

        public IActionResult UpdateMember(
           string id,
           string title,
           string author,
           string e_mail,
           string date,
           string cnt,
           string password,
           string content
           )
            
        {
            DaoMember dao = new DaoMember(_db);
            //dao 객체 연결을 위함

            //date 값은 변하면 안되기에 그대로 가져간다

            try
            {
               
                DtoMember editMember = new DtoMember(
                id,
                title,
                author,
                e_mail,
                0,
                date,
                password,
                content
                );
                //editMember에섣 받아온 내용을 dto를 통해 transfer 해와서 editMember 형성

                dao.UpdateOneMember(editMember);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return RedirectToAction("Member");
            //데이터의 수정이 되었는지의 확인을 위해 다시 member페이지로의 이동
        }

        public IActionResult DeleteMember(string id)
            //모든 데이터가 넘어 오지만 필요한 데이터만을 파라미터로 전달할 수 있다.
        {
            try
            {
                DaoMember dao = new DaoMember(_db);

                dao.UpdateMemberNochool(Int32.Parse(id));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return RedirectToAction("Member");
            //데이터의 삭제가 되었는지의 확인을 위해 다시 member페이지로의 이동
        }

    }
}
