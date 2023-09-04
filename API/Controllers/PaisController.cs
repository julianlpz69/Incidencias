using API.Dtos;
using Aplication.Repository;
using AutoMapper;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{   
    [ApiVersion("1.0")]
    [ApiVersion("1.1")]
    public class PaisController : BaseApiController
    {
        private PaisRepository rr { get; set; }
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper _mapper;


        public PaisController(IUnitOfWork UnitOfWork, IMapper Mapper){
            this.unitOfWork = UnitOfWork;
            _mapper = Mapper;
        }


        [HttpGet]
        [MapToApiVersion("1.1")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PaisXDeparDto>>> Get()
        {
            var paises = await unitOfWork.Paises.GetAllAsync();
            return _mapper.Map<List<PaisXDeparDto>>(paises);
        }


        [HttpGet]
        [MapToApiVersion("1.0")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PaisDto>>> Get11()
        {
            var paises = await unitOfWork.Paises.GetAllAsync();
            return _mapper.Map<List<PaisDto>>(paises);
        }
    }
}