using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Atividade_Avaliativa_fase_6_front.Data;
using Atividade_Avaliativa_fase_6_front.Models;

namespace Atividade_Avaliativa_fase_6_front.Data
{
    public class SeedingService
    {
        private readonly ApplicationDbContext _context;
        public SeedingService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Seed()
        {
            if(_context.AlugueCarro.Any() ||
                _context.Cultura.Any() ||
                _context.DicasUteis.Any() ||
                _context.Entretenimento.Any() ||
                _context.Gastronomia.Any() ||
                _context.Historia.Any() ||
                _context.OndeHospedar.Any() ||
                _context.Parques.Any() ||
                _context.VidaNoturna.Any())
            {
                return;
            }

            AlugueCarro a1 = new AlugueCarro(1, "1001 Transportation", 52, "Providenciamos motoristas treinados, uniformizados e licenciados para levar você e sua família com tranqulidade, conforto e seguranca nas suas férias por toda a região da Flórida.");
            AlugueCarro a2 = new AlugueCarro(2, "Rent cars", 72, "Quer garantir dias incríveis no lugar mais mágico do mundo? Faça já a locação do seu automóvel pela Rentcars.com e curta a sua viagem com tranquilidade, economia e praticidade.");
            AlugueCarro a3 = new AlugueCarro(3, "I-Ride Trolley Service", 654, "Ótima opção para conhecer a International Drive de ponta a ponta, sem pressa.");
            AlugueCarro a4 = new AlugueCarro(4, "Disney's Magical Express", 254, "Se vai ficar hospedado nos hotéis da Disney e não vai precisar alugar carro esta é uma opção excelente... especialmente por estar incluída na sua hospedagem e não ter nenhum custo adicional");
            
            Cultura c1 = new Cultura(1, "Excursão Ghost Tour Interativo pela Downtown Orlando", 419, "Esta excursão de duas horas levará você ao centro histórico de Orlando, lar dos mais assustadores mistérios não resolvidos e dos escândalos assustadores da história de Orlando. Seu experiente guia turístico lhe informará sobre a história desses lugares assustadores e lhe contará histórias de fantasmas em primeira mão. Ao longo do caminho, você vai experimentar equipamentos profissionais de caça fantasma, assim como os profissionais usam.");
            Cultura c2 = new Cultura(2, "Pavões, presidentes e quebra-cabeças - The Winter Park Walking Tour", 214, "Bem-vindo a um dos segredos mais bem guardados da Flórida, a encantadora cidade de Winter Park! Fundado em 1887, Winter Park tem mais de 100 anos e tem o pedigree para provar isso. Sede da primeira faculdade da Flórida, onde vários presidentes dos EUA trocam os calafrios de Washington por um paraíso tropical e o ímã sulista de muitos visitantes famosos, Winter Park tem uma história rica à espera de ser explorada e descoberta!");
            
            DicasUteis d1 = new DicasUteis(1, "Dicas desconto militares Disney Orlando", 
                "Publicado por ulissesucc em 10 de fevereiro de 2019", 
                "Alguém teria dicas atualizadas de descontos para militares dos Parques da Disney, Universal e Sea World? Outros descontos e dicas também serão muito bem...");
            DicasUteis d2 = new DicasUteis(2, "Orlando Fórum: Dicas para Orlando", 
                "Publicado por luismY3462TQ em 20 de março de 2019", 
                "Tenho blog e já escrevi alguns posts falando sobre Orlando, inclusive a chegada, principais providências e algumas dicas. Em breve vou divulgar o post sobre as atrações e quais recomendo. Dê uma olhadinha...");
            DicasUteis d3 = new DicasUteis(3, "Dicas de enxoval!! Marca Skip Hop", 
                "Publicado por decorpetp em 27 de fevereiro de 2019", 
                "Legal as dica, se tiver mais poste assim eu posso fixar o tópico nas perguntas frequentes.");
            DicasUteis d4 = new DicasUteis(4, "O site otel.com é uma cilada", 
                "Publicado por lidiapaz em 25 de julho de 2019", 
                "Excelentes dicas! Desculpa intrometer no assunto, mas também farei uma viagem e as dicas são ótimas!");
            DicasUteis d5 = new DicasUteis(5, "Dicas de roteiro de viagem", 
                "Publicado por Alícia L em 28 de dezembro de 2020", 
                "Gente, Sou nova aqui e estou planejando a minha primeira viagem aos EUA e gostaria muito de dicas pra onde ir, onde ficar e o que fazer lá. Vocês foram em alguma agência ou estão fazendo tudo por conta...");
            DicasUteis d6 = new DicasUteis(6, "Fun Cars Miami", 
                "Publicado por DeborahS2738 em 4 de fevereiro de 2020", 
                "Ola, das 3x que fui na America aluguei com eles e foi tudo certinho, e ainda me ajudaram com informaçoes e dicas. Recomendo.");
            DicasUteis d7 = new DicasUteis(7, "Bebê na disney", 
                "Publicado por evelyn_shiguematsu em 22 de novembro de 2020", 
                "Super dica! Vamos pedir com certeza!");
            DicasUteis d8 = new DicasUteis(8, "Ingressos dos parques de Orlando", 
                "Publicado por Stephanieporfirio16 em 6 de janeiro de 2020", 
                "Pessoal, alguém aqui já comprou ingresso no site da empresa Grupo Dicas (https://grupodicas.com/)? Eles me falaram que representam a empresa OPTUR, alguém...");
            DicasUteis d9 = new DicasUteis(9, "Alguém planejando viagem p/ Orlando no segundo...", 
                "Publicado por Marcelo_ssM em 12 de agosto de 2020", 
                "Oi Tuco vc quer dicas de quais parques ir ou de onde comprar ingressos?");
            DicasUteis d10 = new DicasUteis(10, "Empresa vou para Orlando ė confiável?", 
                "Publicado por Passport605747 em 13 de janeiro de 2021", 
                "Excelente empresa, preço bem mais baixo e a hospedagem foi muito boa! Recebi um otimo atendimento e ainda me auxiliaram com varias dicas de passeios, pois eu nunca tinha viajado para la antes...");
            DicasUteis d11 = new DicasUteis(11, "Dicas para quem vai para Orlando e não quer alugar...", 
                "Publicado por Patricia14b em 22 de janeiro de 2021", 
                "Muito obrigada! Estou começando a pensar na possibilidade do carro pois, o que me deixa preocupada em relação ao aluguel do carro é as tarifas pós devolução do veículo...");
            DicasUteis d12 = new DicasUteis(12, "Guardar compras no quarto do hotel", 
                "Publicado por jhmluna em 14 de fevereiro de 2021", 
                "Alguém teria dicas atualizadas de descontos para militares dos Parques da Disney, Universal e Sea World? Outros descontos e dicas também serão muito bem...");
            DicasUteis d13 = new DicasUteis(13, "Dicas desconto militares Disney Orlando", 
                "Publicado por ulissesucc em 10 de fevereiro de 2019", 
                "Obrigado pelas dicas Gláucia. Minha preocupação era também com relação a um carrinho de bebê que pretendo comprar. Mas como deve vir encaixotada, creio que...");
            
            Entretenimento e1 = new Entretenimento(1, "The Wizarding World of Harry Potter", "Localizada no The Wizarding World of Harry Potter no parque Islands of Adventure.");
            Entretenimento e2 = new Entretenimento(2, "Universal's Islands of Adventure", "O parque Islands of Adventure Orlando é um parque de diversões que faz parte do complexo Universal Orlando Resort.");
            Entretenimento e3 = new Entretenimento(3, "Disney's Animal Kingdom", "Animal Kingdom é o maior parque da Disney em extensão e seu tema principal são os animais e a natureza.");
            Entretenimento e4 = new Entretenimento(4, "Universal Orlando Resort", "Uma atmosfera mágica e com atrações repletas de efeitos especiais e tecnologia.");
            Entretenimento e5 = new Entretenimento(5, "Discovery Cove - Orlando", "Golfinhos, peixes, comida à vontade.");
            Entretenimento e6 = new Entretenimento(6, "Disney Springs", "Não vá para Orlando e fique sem visitar o melhor complexo de lojas da Disney.");
            Entretenimento e7 = new Entretenimento(7, "Magic Kingdom", "Lá você volta a ser criança de verdade.");
            Entretenimento e8 = new Entretenimento(8, "Lake Rianhard", "Celebration é um lugar muito tranquilo, um ótimo lugar para comtemplar e relaxar, principalmente depois de sair do tumulto dos parques.");
            Entretenimento e9 = new Entretenimento(9, "Epcot", "É um dos parques temáticos construídos no Walt Disney World e dedicado à celebração da inovação tecnológica e cultura internacional.");
            
            Gastronomia g1 = new Gastronomia(1, "Zeta Asia", 1510, "Ótimo jantar no Hilton Hotel.", "Clássica e Linda");
            Gastronomia g2 = new Gastronomia(2, "Ghirardelli Soda Fountain & Chocolate Shop", 600, "Parada obrigatória!!", "incríveis!");
            Gastronomia g3 = new Gastronomia(3, "Chuy’s", 2222, "Ameiiii", "Mexicano pronto para o seu paladar!");
            Gastronomia g4 = new Gastronomia(4, "Flamingo's Bar & Grille", 2711, "Agradável", "Ótimo trabalho, Casey!");
            Gastronomia g5 = new Gastronomia(5, "Chef Art Smith's Homecomin'", 1405, "Recomendamos para quem passar pelo Disney...", "Excelente");
            Gastronomia g6 = new Gastronomia(6, "Bonefish Grill", 583, "Ótimo", "Um pouco caro!");
            Gastronomia g7 = new Gastronomia(7, "Wine Bar George - A Restaurant & Bar", 315, "Melhor opção do Disney Springs", "Recomendo");
            
            Historia h1 = new Historia(1, "The Orange County Regional History Center", 15, "Vale muito a pena conhecer!!!", "Muito bom!");
            Historia h2 = new Historia(2, "Charles Hosmer Morse Museum of American Art", 7, "Vale a pena em qualquer estação", "Surpreendente");
            Historia h3 = new Historia(3, "Orlando Museum of Art", 5, "Interessante", "Este museu é bem legal");
            
            OndeHospedar o1 = new OndeHospedar(1, "Walt Disney World Dolphin", 
                1510, 
                "1º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Com medidas de segurança",
                "");
            OndeHospedar o2 = new OndeHospedar(2, "The Grove Resort & Water Park Orlando", 
                600, 
                "2º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Bar/Lounge",
                "Com medidas de segurança");
            OndeHospedar o3 = new OndeHospedar(3, "Loews Sapphire Falls Resort At Universal Orlando", 
                2222, 
                "3º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Serviço de quarto",
                "Com medidas de segurança");
            OndeHospedar o4 = new OndeHospedar(4, "Universal’s Endless Summer Resort – Dockside Inn and Suites", 
                2711, 
                "4º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Com medidas de segurança",
                "Serviço de quarto");
            OndeHospedar o5 = new OndeHospedar(5, "Hyatt Regency Orlando International Airport", 
                1405, 
                "5º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Com medidas de segurança",
                "Serviço de quarto");
            OndeHospedar o6 = new OndeHospedar(6, "Universal's Cabana Bay Beach Resort", 
                583, 
                "6º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Restaurante",
                "Serviço de quarto");
            OndeHospedar o7 = new OndeHospedar(7, "Orlando World Center Marriott", 
                315, 
                "7º melhor custo-benefício de 2.487 lugares para se hospedar em: Orlando",
                "Wi-fi gratuito",
                "Bar/Lounge",
                "");
            
            Parques p1 = new Parques(1, "Disney's Animal Kingdom", 1510, "Animal Kingdom serve como uma plataforma multi-local para mostrar o amor da Disney pela natureza.");
            Parques p2 = new Parques(2, "Disney Springs", 600, "Um ótimo lugar para passear, durante o dia ou a noite, boas lojas e ótimos restaurantes, diversão garantida para todas as idades.");
            Parques p3 = new Parques(3, "Magic Kingdom", 2222, "Aqui todo mundo volta a ser criança! Diversão garantida e atmosfera mágica!");
            Parques p4 = new Parques(4, "Epcot", 2711, "É um dos parques temáticos construídos no Walt Disney World e dedicado à celebração da inovação tecnológica e cultura internacional.");
            Parques p5 = new Parques(5, "Avatar Flight of Passage", 1405, "Uma das melhores atrações da Disney.");
            Parques p6 = new Parques(6, "Pandora - The World of Avatar", 583, "Conforme você vai entrando no Mundo de Pandora, a vegetação e os sons se transformam fazendo você se sentir em um mundo mágico.");
            Parques p7 = new Parques(7, "Typhoon Lagoon", 315, "Parque aquático temático, organizado, seguro e alegre.");
            
            VidaNoturna v1 = new VidaNoturna(1, "O Show de Comédia Mágica Outta Control Magic", 24, "R$ 193,13");
            VidaNoturna v2 = new VidaNoturna(2, "Assentos VIP", 3, "R$ 283,43");
            VidaNoturna v3 = new VidaNoturna(3, "Singing your Dreams - Dinner Show in Orlando", 56, "R$ 334,44");
            VidaNoturna v4 = new VidaNoturna(4, "Mesa Premier", 11, "R$ 2210,73");

            _context.AlugueCarro.AddRange(a1, a2, a3, a4);
            _context.Cultura.AddRange(c1, c2);
            _context.DicasUteis.AddRange(d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13);
            _context.Entretenimento.AddRange(e1, e2, e3, e4, e5, e6, e7, e8, e9);
            _context.Gastronomia.AddRange(g1, g2, g3, g4, g5, g6, g7);
            _context.Historia.AddRange(h1, h2, h3);
            _context.OndeHospedar.AddRange(o1, o2, o3, o4, o5, o6, o7);
            _context.Parques.AddRange(p1, p2, p3, p4, p5, p6, p7);
            _context.VidaNoturna.AddRange(v1, v2, v3, v4);
            
            _context.SaveChanges();
        }
    }
}