using System.Collections.ObjectModel;
using FitNutri.Models;

namespace FitNutri.Views;

public partial class FeedPage : ContentPage
{
    public ObservableCollection<Post> MeusPosts { get; set; }

    public FeedPage()
    {
        InitializeComponent();

        MeusPosts = new ObservableCollection<Post>
        {
            new Post 
            { 
                NomeUsuario = "Carlos Alberto", 
                Tempo = "Há 2 horas", 
                Conteudo = "Batendo as metas diárias de proteína. 💪🔥", 
                ImagemPost = "foto_feed_arroz.png",
                FotoPerfil = "user_avatar.png"
            },
            new Post 
            { 
                NomeUsuario = "Mariana Silva", 
                Tempo = "Há 5 horas", 
                Conteudo = "Dica de hoje: Não esqueçam de se hidratar! 💧✨", 
                ImagemPost = "foto_feed_agua.png", 
                FotoPerfil = "user_avatar.png"
            },
            new Post 
            { 
                NomeUsuario = "João Paulo", 
                Tempo = "Ontem", 
                Conteudo = "Treino de hoje concluído com sucesso. Foco no objetivo!", 
                ImagemPost = "foto_feed_treino.png", 
                FotoPerfil = "user_avatar.png"
            }
        };

        BindingContext = this;
    }
}
