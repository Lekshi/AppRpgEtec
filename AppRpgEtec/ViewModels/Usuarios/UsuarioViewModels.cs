using System;
using AppRpgEtec.Services.Usuario

public class UsuarioViewModels: BaseViewModel
{
	private UsuarioService uService;
	public Icommand RegistrarCommand { get; set; }

	#region AtributosPropriedades
	//As propriedades serão chamadas na Viwe futuramente
	public string login = string.Empty;
	public string Login
	{ 
		get { return login; }
		set { login = value; OnPropertyChanged(); }
	}
	private string senha = string.Empty;
	public string Senha
	{
		get { return senha; }
		set { senha = value; OnPropertyChanged(); }
	}

    public UsuarioViewModels()
	{
	}
}
