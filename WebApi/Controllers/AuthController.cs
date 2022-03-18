using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : BaseApiController
    {
        private readonly IConfiguration _configuration;

        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        /// <summary>
        /// Make it User Login operations
        /// </summary>
        /// <param name="loginModel"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IDataResult<AccessToken>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [HttpPost("Login")]
        public async Task<IActionResult> Login([FromBody] LoginUserQuery loginModel)
        {
            var result = await Mediator.Send(loginModel);
            //return !(result?.Success) ? Unauthorized(result.Message) : Ok(result);
            throw new System.NotImplementedException();
        }

        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IDataResult<AccessToken>))]
        [ProducesResponseType(StatusCodes.Status401Unauthorized, Type = typeof(string))]
        [HttpPost("RefreshToken")]
        public async Task<IActionResult> LoginWithRefreshToken([FromBody] LoginUserQuery command)
        {
            var result = await Mediator.Send(command);
            //return result.Success ? Ok(result) : BadRequest(result);
            throw new System.NotImplementedException();
        }

        //private IActionResult BadRequest(object modelState)
        //{
        //    throw new System.NotImplementedException();
        //}

        /// <summary>
        ///  Make it User Register operations
        /// </summary>
        /// <param name="createUser"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IResult))]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] LoginUserQuery createUser)
        {
            return GetResponseOnlyResult(await Mediator.Send(createUser));
        }

        /// <summary>
        /// Make it Forgot Password operations
        /// </summary>
        /// <remarks>tckimlikno</remarks>
        /// <return></return>
        /// <response code="200"></response>
        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(IResult))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(IResult))]
        [HttpPut("forgotpassword")]
        public async Task<IActionResult> ForgotPassword([FromBody] LoginUserQuery forgotPassword)
        {
            return GetResponseOnlyResult(await Mediator.Send(forgotPassword));
        }

        /// <summary>
        /// Make it Change Password operation
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPut("changeuserpassword")]
        public async Task<IActionResult> ChangeUserPassword([FromBody] LoginUserQuery command)
        {
            return GetResponseOnlyResultMessage(await Mediator.Send(command));
        }

        /// <summary>
        /// Mobile Login
        /// </summary>
        /// <param name="verifyCid"></param>
        /// <returns></returns>
        [AllowAnonymous]
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [HttpPost("verify")]
        public async Task<IActionResult> Verification([FromBody] LoginUserQuery verifyCid)
        {
            return GetResponseOnlyResultMessage(await Mediator.Send(verifyCid));
        }

        /// <summary>
        /// Token decode test
        /// </summary>
        /// <returns></returns>
        [Consumes("application/json")]
        [Produces("application/json", "text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [HttpPost("test")]
        public IActionResult LoginTest()
        {
            var auth = Request.Headers["Authorization"];
            var token = new JwtHelper(_configuration).DecodeToken(auth);

            return Ok(token);
        }
    }

    public class JwtHelper
    {
        public JwtHelper(IConfiguration configuration)
        {
            throw new System.NotImplementedException();
        }

        public object DecodeToken(StringValues auth)
        {
            throw new System.NotImplementedException();
        }
    }

    public class UserChangePasswordCommand
    {
    }

    public class ForgotPasswordCommand
    {
    }

    public class RegisterUserCommand
    {
    }

    public class VerifyCidQuery
    {
    }

    public interface IResult
    {
    }

    public class LoginUserQuery
    {
    }

    public class LoginWithRefreshTokenQuery
    {
    }

    public class AccessToken
    {
    }

    public interface IDataResult<T>
    {
        bool Success { get; set; }
        object Data { get; set; }
        object Message { get; set; }
    }
}