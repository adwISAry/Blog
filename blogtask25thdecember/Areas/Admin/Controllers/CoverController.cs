using blogtask25thdecember.Areas.Admin.ViewModels;
using blogtask25thdecember.Models.Cover;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace blogtask25thdecember.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class CoverController : Controller
	{
		ApplicationDbContext _db { get; }

		public CoverController(ApplicationDbContext db)
		{
			_db = db;
		}

		public async Task<IActionResult> Index()
		{
			var items = await _db.Covers.Select(s => new AdminCoverListItemVM
			{
				Id = s.Id,
				Image = s.Image,

			}).ToListAsync();
			return View(items);
		}

		[HttpPost]

		public IActionResult Create()
		{
			ViewBag.Covers = _db.Covers;
			return View();
		}
		public async Task<IActionResult> Create(CoverCreateVM vm)
		{

			if (vm.Image == null)
			{
				ModelState.AddModelError("Image","Image is required");
			}
			if (!ModelState.IsValid)
			{
				ViewBag.Covers = _db.Covers;
				return View(vm);
			}
			if (!await _db.Covers.AnyAsync(c => c.Id == vm.Id))
			{
				ModelState.AddModelError("Id", "No Cover");
				ViewBag.Covers = _db.Covers;
				return View(vm);
			}
			var rootpath = Directory.GetCurrentDirectory();
			var imagepath = Path.Combine(rootpath, "wwwroot/prodimages");
			//var fileName = Guid.NewGuid().ToString() + vm.formFile.FileName;
			//var imageFile = System.IO.File.Create(Path.Combine(imagepath, fileName));

			//await vm.formFile.CopyToAsync(imageFile);
			//imageFile.Close();

			Cover cover = new Cover
			{
				Id = vm.Id,
				Image = vm.Image



			};

			await _db.Covers.AddAsync(cover);
			await _db.SaveChangesAsync();

			return RedirectToAction(nameof(Index));
		}


		public async Task<IActionResult> Delete(int? id)
		{
			TempData["Response"] = false;
			if (id == null) return BadRequest();
			var data = await _db.Covers.FindAsync(id);
			if (data == null) return NotFound();
			_db.Covers.Remove(data);
			await _db.SaveChangesAsync();
			TempData["Response"] = true;
			return RedirectToAction(nameof(Index));
		}

		public async Task<IActionResult> Update(int? id)
		{
			if (id == null || id <= 0) return BadRequest();
			var data = await _db.Covers.FindAsync(id);
			if (data == null) return NotFound();
			return View(new AdminCoverListItemVM
			{

			});
		}

		//[HttpPost]

		//public async Task<IActionResult> Update(int? id, AdminCoverListItemVM vm)
		//{

		//}
	}

}
