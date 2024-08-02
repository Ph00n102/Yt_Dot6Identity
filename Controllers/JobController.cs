using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Yt_Dot6Identity.Models;
using Yt_Dot6Identity.Models.Domain;


namespace SKNHPM.Controllers
{

    public class JobController : Controller
    {
        private readonly DatabaseContext context;
        public JobController(DatabaseContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            Response.Headers.Add("Refresh","3");
            var nurserequest = context.NurseRequest.OrderByDescending(p => p.JobId).ToList();
            return View(nurserequest);
        }
         public IActionResult Create()
         {
             return View();
         }

        [HttpPost]
        public IActionResult Create(NurseRequestDto nurseRequestDto)
        {
            if (ModelState.IsValid)
            {
                return View(nurseRequestDto);
            }
            
            NurseRequest nurseRequest = new NurseRequest()
            {
                // QN = nurseRequestDto.QN,
                // QNName = nurseRequestDto.QNName,
                // StartPoint = nurseRequestDto.StartPoint,
                // EndPoint = nurseRequestDto.EndPoint,
                // MaterialType = nurseRequestDto.MaterialType,
                // UrentType = nurseRequestDto.UrentType,
                // PatientType = nurseRequestDto.PatientType,
                // Remark = nurseRequestDto.Remark,
                // Department = "null",
                // PoterFname = "null",
                // QNAge = "null",
                // QNSex = "null",
                PoterFname = nurseRequestDto.PoterFname,
                JobStatusName = nurseRequestDto.JobStatusName
            };
            context.NurseRequest.Add(nurseRequest);
            context.SaveChanges();
            return RedirectToAction("Index", "Job");
        }

        public IActionResult Edit(int id)
        {
            ViewBag.getnurseRequest = context.NurseRequest.ToList();
            var nurseRequest = context.NurseRequest.Find(id);
            if(nurseRequest == null)
            {
                return RedirectToAction("Index", "Job");
            }
            var nurseRequestDto = new NurseRequestDto()
            {
                // QN = nurseRequest.QN,
                // QNName = nurseRequest.QNName,
                // StartPoint = nurseRequest.StartPoint,
                // EndPoint = nurseRequest.EndPoint,
                // MaterialType = nurseRequest.MaterialType,
                // UrentType = nurseRequest.UrentType,
                // PatientType = nurseRequest.PatientType,
                // Remark = nurseRequest.Remark,
                // Department = "null",
                // PoterFname = "null",
                // QNAge = "null",
                // QNSex = "null",
                PoterFname = nurseRequest.PoterFname,
                JobStatusName = nurseRequest.JobStatusName
            };

             ViewData["NurseRequestId"] = nurseRequest.JobId;

            return View(nurseRequestDto);
        }
        [HttpPost]
         public IActionResult Edit(int id, NurseRequestDto nurseRequestDto)
         {
            var nurseRequest = context.NurseRequest.Find(id);
            if(nurseRequest == null)
            {
                return RedirectToAction("Index", "Job");
            }
            if (ModelState.IsValid)
            {
                ViewData["NurseRequestId"] = nurseRequest.JobId;
                return View(nurseRequestDto);
            }

            // nurseRequest.QN = nurseRequestDto.QN;
            // nurseRequest.QNName = nurseRequestDto.QNName;
            // nurseRequest.StartPoint = nurseRequestDto.StartPoint;
            // nurseRequest.EndPoint = nurseRequestDto.EndPoint;
            // nurseRequest.MaterialType = nurseRequestDto.MaterialType;
            // nurseRequest.UrentType = nurseRequestDto.UrentType;
            // nurseRequest.PatientType = nurseRequestDto.PatientType;
            // nurseRequest.Remark = nurseRequestDto.Remark;
            nurseRequest.PoterFname = nurseRequestDto.PoterFname;
            nurseRequest.JobStatusName = nurseRequestDto.JobStatusName;

            context.SaveChanges();

            return RedirectToAction("Index", "Job");
         }
         public IActionResult Delete(int id)
        {
            var nurseRequest = context.NurseRequest.Find(id);
            if(nurseRequest == null)
            {
                return RedirectToAction("Index", "Job");
            }
            context.NurseRequest.Remove(nurseRequest);
            context.SaveChanges(true);

            return RedirectToAction("Index", "Job");
        }
        
    }

}