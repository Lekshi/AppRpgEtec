using System;
using AppRpgEtec.Models

public class UsuarioService : Request
{
    private readonly Request _request;
	private const string apiUrlBase = "http://xyz.somee.com/RpgApi/Usuarios";
	//xyz --> site api

    public UsuarioService()
	{
		_request = new Request();
	}

	public async Task<Usuario> PostRegistrarUsuarioAsync(Usuario u)
	{
		//Registrar: Rota para o método na API que registra o usuário
		string urlComplementar = "/Registrar";
		u.Id = await _rquest.PostreturnIntAsync(apiUrlBase + urlComplementar, u);
		return u;
	}
	public async Task<Usuario> PostAutenticarUsuarioAsync(Usuario u)
	{
		//Autenticar: Rota para o método na API que autentica com login e senha
		string urlComplementar = "/Autenticar";
		u = await _request.PostAsync(apiUrlBase + urlComplementar, u, string.Empty);
		return u;
	}
}
