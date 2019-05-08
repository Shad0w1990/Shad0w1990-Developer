using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Developer{

public class HomeController:Controller{
	public IActionResult Create(){
		return Ok();
	}
	public IActionResult Index(){
		return Content("hello");
	}
}
}