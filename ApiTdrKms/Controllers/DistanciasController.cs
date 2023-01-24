using ApiTdrKms.Modelos.Dtos;
using ApiTdrKms.Repositorio.IRepositorio;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace ApiTdrKms.Controllers
{
    [ApiController]
    //[Route("api/[controller]")]
    [Route("api/distancias")]
    public class DistanciasController : ControllerBase
    {
        private readonly IDistanciaRepositorio _ctRepo;
        private readonly IMapper _mapper;

        public DistanciasController(IDistanciaRepositorio ctRepo, IMapper mapper)
        {
            _ctRepo = ctRepo;
            _mapper = mapper;
        }
        [HttpGet]
        public IActionResult GetInfo()
        {
            var listaDistancias = _ctRepo.GetInfo();

            var listasDistanciasDto = new List<DistanciaDto>();

            foreach (var lista in listaDistancias)
            {
                listasDistanciasDto.Add(_mapper.Map<DistanciaDto>(lista));
            }
            return Ok(listasDistanciasDto);
        }
        [HttpGet("{fechaInicio}/{fechaFin}", Name = "GetDistancia")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult GetDistancia(string fechaInicio, string fechaFin)
        {
            string token = "INTRA2501181256xTrFl33t";
            var itemDistancia = _ctRepo.GetDistancia(fechaInicio, fechaFin, token);

            if (itemDistancia == null)
            {
                return NotFound();
            }

            var listasDistanciasDto = new List<DistanciaDto>();

            foreach (var lista in itemDistancia)
            {
                listasDistanciasDto.Add(_mapper.Map<DistanciaDto>(lista));
            }
            return Ok(listasDistanciasDto);

        }

    }
}
