using API.Dtos;
using API.Helpers;
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
        public async Task<ActionResult<Pager<PaisXDeparDto>>> Get([FromQuery] Params paisParams)
        {
            var pais = await unitOfWork.Paises.GetAllAsync(paisParams.PageIndex, paisParams.PageSize, paisParams.Search);
            var lstPaisesDto = _mapper.Map<List<PaisXDeparDto>>(pais.registros);
            return new Pager<PaisXDeparDto>(lstPaisesDto, pais.totalRegistros, paisParams.PageIndex, paisParams.PageSize, paisParams.Search);
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



         [HttpPost]
         [MapToApiVersion("1.0")]
         [ProducesResponseType(StatusCodes.Status201Created)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
         public async Task<ActionResult<Pais>> Post(PaisDto PaisDto)
         {
            var pais = this._mapper.Map<Pais>(PaisDto);
             unitOfWork.Paises.Add(pais);
            await unitOfWork.SaveAsync();
        
            if (pais == null){
                return BadRequest();
            }
            PaisDto.Id = pais.Id;
            return CreatedAtAction(nameof(Post), new {id = PaisDto.Id}, PaisDto);
         }

         [HttpPut("{id}")]
         [MapToApiVersion("1.0")]
         [ProducesResponseType(StatusCodes.Status200OK)]
         [ProducesResponseType(StatusCodes.Status404NotFound)]
         [ProducesResponseType(StatusCodes.Status400BadRequest)]
         
         public async Task<ActionResult<PaisDto>> Put(int id, [FromBody]PaisDto paisDto){
            if(paisDto == null)
                return NotFound();
         
            var pais = this._mapper.Map<Pais>(paisDto);
            unitOfWork.Paises.Update(pais);
            await unitOfWork.SaveAsync();
            return paisDto;
         }



         [HttpDelete("{id}")]
         [MapToApiVersion("1.0")]
         [ProducesResponseType(StatusCodes.Status204NoContent)]
         [ProducesResponseType(StatusCodes.Status404NotFound)]
         
         public async Task<IActionResult> Delete (int id){
         var pais = await unitOfWork.Paises.GetByIdAsync(id);
         if(pais == null)
         return NotFound();
         
         unitOfWork.Paises.Remove(pais);
         await unitOfWork.SaveAsync();
         return NoContent();    }
    }
}