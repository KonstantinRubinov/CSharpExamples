using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace RestWebApi
{
	[EnableCors("*", "*", "*")]
	[RoutePrefix("api")]
	public class HeroesApiController : ApiController
    {
		private IHeroesRepository heroesRepository;

		public HeroesApiController(IHeroesRepository _heroesRepository)
		{
			heroesRepository = _heroesRepository;
		}

		[HttpGet]
		[Route("heroes")]
		public HttpResponseMessage GetAllHeroes()
		{
			try
			{
				List<Hero> allHeros = heroesRepository.GetAllHeroes();
				return Request.CreateResponse(HttpStatusCode.OK, allHeros);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpGet]
		[Route("heroes/{id}")]
		public HttpResponseMessage GetHeroById(int id)
		{
			try
			{
				Hero oneHero = heroesRepository.GetHeroById(id);
				return Request.CreateResponse(HttpStatusCode.OK, oneHero);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpGet]
		[Route("heroes/top")]
		public HttpResponseMessage GetFourHeroes()
		{
			try
			{
				List<Hero> fourHeros = heroesRepository.GetFourHeroes();
				return Request.CreateResponse(HttpStatusCode.OK, fourHeros);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPost]
		[Route("heroes")]
		public HttpResponseMessage AddHero([FromBody]Hero hero)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}
				Hero addedHero = heroesRepository.PostHero(hero);
				return Request.CreateResponse(HttpStatusCode.Created, addedHero);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpPut]
		[Route("heroes/{id}")]
		public HttpResponseMessage UpdateHero(int id, [FromBody]Hero hero)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					Errors errors = ErrorsHelper.GetErrors(ModelState);
					return Request.CreateResponse(HttpStatusCode.BadRequest, errors);
				}

				hero.id = id;
				Hero updatedHero = heroesRepository.UpdateHero(hero);
				return Request.CreateResponse(HttpStatusCode.OK, updatedHero);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}

		[HttpDelete]
		[Route("heroes/{id}")]
		public HttpResponseMessage DeleteHero(int id)
		{
			try
			{
				heroesRepository.DeleteHero(id);
				return Request.CreateResponse(HttpStatusCode.NoContent);
			}
			catch (Exception ex)
			{
				Errors errors = ErrorsHelper.GetErrors(ex);
				return Request.CreateResponse(HttpStatusCode.InternalServerError, errors);
			}
		}
		




	}
}
