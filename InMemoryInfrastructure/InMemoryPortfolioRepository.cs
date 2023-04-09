using Domains.Models.Portofolios;
using System.Collections.Generic;

namespace InMemoryInfrastructure
{
    public class InMemoryPortfolioRepository : IPortfolioRepository
    {
        private Dictionary<string, Portfolio> _portfolios;

        public InMemoryPortfolioRepository()
        {
            _portfolios = new Dictionary<string, Portfolio>();
            var folio = new Portfolio("1", GetWorkItems(), GetSkillItems(), GetCertificationItems());

            _portfolios.Add("1", folio);
        }

        public Portfolio Find(string id)
        {
            if (_portfolios.ContainsKey(id))
            {
                return _portfolios[id];
            }
            return null;
        }

        private List<CertificationItem> GetCertificationItems()
        {
            var items = new List<CertificationItem>();
            items.Add(new CertificationItem("1", "Azure Solutions Architect Expert(AZ-303,304)", "2021/9", "image/portfolio/qua/az_exp.png"));
            items.Add(new CertificationItem("2", "Azure Administrator Associate(AZ-103)", "2021/8", "image/portfolio/qua/az_asso.png"));
            items.Add(new CertificationItem("3", "Azure Fundamentals(AZ-900)", "2021/5", "image/portfolio/qua/az_fund.png"));
            items.Add(new CertificationItem("4", "TOEIC Score: 800", "2018", "image/portfolio/qua/cert.svg"));
            items.Add(new CertificationItem("5", "認定スクラムプロダクトオーナー(LSPO)", "2021/9", "image/portfolio/qua/cert2.svg"));
            items.Add(new CertificationItem("6", "情報セキュリティスペシャリスト", "2013/8", "image/portfolio/qua/cert.svg"));
            items.Add(new CertificationItem("7", "応用情報技術者試験", "2011/8", "image/portfolio/qua/cert.svg"));
            items.Add(new CertificationItem("8", "基本情報技術者試験", "2010/8", "image/portfolio/qua/cert.svg"));
            return items;
        }

        private List<SkillItem> GetSkillItems()
        {
            var skills = new List<SkillItem>();

            skills.Add(new SkillItem("1", "C#(.NET)",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("1","Web (ASP.NET MVC, Blazor, Silverlight)", 90),
                    new SkillSubItem("2","Desktop (WPF, WinForms)", 80),
                    new SkillSubItem("3","Mobile (Xamarin Forms)", 30),
                }));

            skills.Add(new SkillItem("2", "JavaScript, TypeScript",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("10","Node.js", 60),
                    new SkillSubItem("11","Vue.js, Nuxt.js", 60),
                    new SkillSubItem("12","Angular", 30),
                    new SkillSubItem("13","React", 40),
                }));

            skills.Add(new SkillItem("3", "Others",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("20","Python (Django)", 50),
                    new SkillSubItem("21","Ruby (Rails)", 40),
                    new SkillSubItem("22","Go", 30),
                }));

            skills.Add(new SkillItem("4", "RDBMS",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("30","SQL Server", 80),
                    new SkillSubItem("31","PostgreSQL", 40),
                    new SkillSubItem("32","MySQL", 20)
                }));

            skills.Add(new SkillItem("5", "NoSQL",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("40","FireStore", 60),
                    new SkillSubItem("41","DynamoDB", 50),
                    new SkillSubItem("42","MongoDB", 30),
                    new SkillSubItem("43","Redis", 30),
                }));

            skills.Add(new SkillItem("6", "Cloud Services",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("50","Firebase (Hosting, FireStore, etc)", 70),
                    new SkillSubItem("51","AWS (EC-2, Lambda, etc)", 50),
                    new SkillSubItem("52","Azure (VM, Functions, etc)", 30),
                    new SkillSubItem("53","Heroku", 40),
                    new SkillSubItem("54","PythonAnywhere", 40),
                }));

            skills.Add(new SkillItem("7", "etc...",
                new List<SkillSubItem>()
                {
                    new SkillSubItem("60","Windows Server(2003,2008,2012,2019)", 70),
                    new SkillSubItem("61","Hyper-V (Failover Clustering)", 60),
                    new SkillSubItem("62","CentOS", 40),
                    new SkillSubItem("63","Docker", 40),
                }));

            return skills;
        }

        private List<WorkItem> GetWorkItems()
        {
            var works = new List<WorkItem>();

            works.Add(new WorkItem("15", "CHICO★SPICEテイクアウト予約", "テイクアウト予約サイト",
                "CHICO★SPICEのテイクアウト予約サイト。フロントエンドはReat、サーバーサイドはGo(Gin)で実装。UIは結構頑張って使いやすくなった。",
                "Go, Gin, Typescript, Material UI, PostgreSQL", "Fly.io, Firebase",
                @"https://chicotakeout.fly.dev", @"https://github.com/nobu17/chico_takeout",
                @"image/portfolio/chiko.png",
                new List<string>() { @"image/portfolio/chicotake.png" }));

            works.Add(new WorkItem("14", "ISBN Book Titler Fyne", "自炊本リネームツールVer2",
                "以前.NETで作成していた、ISBN Book TitlerをGoで作成し直したもの。GUIはFyneを使用。Windows以外でも動作する(はず)。",
                "Go, Fyne", "ローカルアプリ",
                @"https://nobunobu1717.site/?p=2635", @"https://github.com/nobu17/ISBN-Book-Titler-Fyne",
                @"image/portfolio/bookt3.png",
                new List<string>() { @"image/portfolio/fyne1.png" }));

            works.Add(new WorkItem("13", "キラリ高校学園祭 2021", "オンライン学園祭",
                "コロナの影響でハイブリット形式で開催された学園祭のウェブサイトを構築。ReactでTypescritptを使用。Chakra UIの癖が強く、UIはちょっと苦戦した。",
                "React(Typescript), Chakra UI", "firebase(Hosting, Store, Authentication, Storage),",
                @"", @"https://github.com/nobu17/kirari_fes_app",
                @"image/portfolio/kfes.png",
                new List<string>() { @"image/portfolio/kfes.png" }));

            works.Add(new WorkItem("12", "fujimusic", "ギター教室(React版)",
                "私も参加しているギター教室。Vue.jsで作ったものをオライリーのReact本でのアウトプットとしてReact Hookを使って再構築したもの。",
                "React(Javascript), Material UI", "firebase(Hosting, Store, Authentication, Storage),",
                @"https://fujimusicpj.web.app/", @"https://github.com/nobu17/fujimusic_react_app",
                @"image/portfolio/guitar1.svg",
                new List<string>() { @"image/portfolio/fuji_react1.png" }));

            works.Add(new WorkItem("11", "CHICO★SPICE予約", "店舗予約サイト",
                "CHICO★SPICEの店舗予約サイト。Djangoのお勉強を兼ねて作成。UIはBulumaを使用してみた。PythonAnywhere上で無料ホスト。",
                "Python Django, Buluma, MySQL", "PythonAnyWhere",
                @"https://nobu17.pythonanywhere.com/", @"https://github.com/nobu17/chico_reseve",
                @"image/portfolio/chiko.png",
                new List<string>() { @"image/portfolio/chicore.png" }));

            works.Add(new WorkItem("10", "Oreilly Map", "オライリーの動物本への愛",
                "オライリーの特約店を地図上から探せるサイト。情報はオーム社のHPからNode.jsでスクレイピングしてjson化して利用。UIはMudaBlazorを使用してみた。",
                "C#,Blazor, MudaBlazor, Node.js(Tool)", "firebase",
                @"https://nobu17.github.io/oreilly_map/", @"https://github.com/nobu17/oreilly_map",
                @"image/portfolio/ckame.png",
                new List<string>() { @"image/portfolio/olmap.png" }));

            works.Add(new WorkItem("9", "Nobu's portfolio", "ポートフォリオサイト",
                "本サイト。遂に正式リリースとなったBlazor WebAssemblyを使って作成したポートフォリオサイトです。某DDD本のアウトプットとしてなんちゃってDDDで実装。",
                "C#,Blazor, MDBootstrap", "GitHub.io",
                @"https://nobu17.github.io/Nobus_portfolio/", @"https://github.com/nobu17/Nobus_portfolio",
                @"image/portfolio/kae1.svg",
                new List<string>() { @"image/portfolio/ptf1.png" }));

            works.Add(new WorkItem("8", "SURUGA-BU(駿河部)", "静岡県東部の紹介メディア",
                "Railsの勉強を兼ねて作成したサイト。Blogをフルスクラッチで作成した形。記事の投稿はMarkdownにて記載する。Herokuの無料プランで運用中(StorageだけGCP)。無料である程度できるのは嬉しいが、同じ無料でもfirebaseでSPAで作る方が数倍楽とわかった。",
                "Ruby on Rails", "Heroku, PostgreSQL, Redis, GCS",
                @"https://surugabu.com/", @"https://github.com/nobu17/surugabu/",
                @"image/portfolio/maguro.svg",
                new List<string>() { @"image/portfolio/surugabu1.png" }));

            works.Add(new WorkItem("7", "AngularBookSearch", "古本価格調査サイト",
                "個人的な趣味の古本購入時のツールとして開発。Angularを使用。APIはAWS LambdaでGrapghQLで作成。前身として作ったBlazor版も存在する。",
                "Typescript, Angular, PrimeNG(WEB-UI), Node.js(API)", "firebase, AWS(Lambda, API Gateway)",
                @"https://angularbooksearch.web.app/", @"https://github.com/nobu17/AngularBookScanApp/",
                @"image/portfolio/bookt3.png",
                new List<string>() { @"image/portfolio/angb1.png", @"image/portfolio/angb2.png", @"image/portfolio/angb3.png" }));

            works.Add(new WorkItem("6", "CHICO★SPICE", "カレーショップ",
                "知り合いのお店をNuxt.jsの勉強を兼ねて作成。今も定期的に更新中。",
                "Nuxt.js, Vue.js, Vuetify", "firebase(Hosting, Store, Authentication, Storage),Auth0, MicroCMS",
                @"https://chico-sp-website.web.app/", @"https://github.com/nobu17/chiko_sp",
                @"image/portfolio/chiko.png",
                new List<string>() { @"image/portfolio/chico1.png", @"image/portfolio/chico2.png" }));

            works.Add(new WorkItem("5", "Braidal Quiz", "リアルタイム集計クイズ",
                "結婚式の余興のために作成。fire storeを使用して双方向通信による回答状況のリアルタイムの集計を実施して、参加者皆が楽しめる余興となった。",
                "Nuxt.js, Vue.js, Vuetify", "firebase(Hosting, Store, Storage),",
                @"", @"https://github.com/nobu17/bridal_quiz",
                @"image/portfolio/marrage1.svg",
                new List<string>() { @"image/portfolio/brd1.png", @"image/portfolio/brd2.png" }));

            works.Add(new WorkItem("4", "ItemObserveApp", "古本価格監視アプリ",
                "個人的な趣味の古本購入時のツールとしてXamarin.Formsで開発。APIはAWS Lambda上にGo言語でなんちゃってクリーンアーキテクチャを試みた。15分間隔で価格を監視して、閾値が下がったらメールにて通知する。このアプリのおかげで多くの本が安く買えた。",
                "C#, Xamarin.Forms, Prism(UI), Go(API)", "スマホアプリ、AWS(Cognito, Dynamo, Lambda, API Gateway, SQS, SNS)",
                @"", @"https://github.com/nobu17/ItemObserveApp",
                @"image/portfolio/book2.svg",
                new List<string>() { @"image/portfolio/noimage.png" }));

            works.Add(new WorkItem("3", "fujimusic", "ギター教室",
                "私も参加しているギター教室。初めてVue.jsで本格的に作成したWEBサイト。firebaseのノウハウが何もない状態で作ったので、データストアとしてfire storeを使わずにfunctionsとjsonを使って実装。パフォーマンスが悪いのでいつか直したい。=> Reactで作り直しました。",
                "Vue.js(Javascript), Vuetify, Node.js(Typescript)", "firebase(Hosting, Functions, Authentication, Storage),",
                @"https://fujimusicpj.web.app/", @"https://github.com/nobu17/fujimusic",
                @"image/portfolio/guitar1.svg",
                new List<string>() { @"image/portfolio/fuji1.png" }));

            works.Add(new WorkItem("2", "YahooAuctionReminder", "ヤフオク監視アプリ",
                "当時利用していたヤフオクで入札忘れが多く、防止のために終了5分前くらいに通知してくれるスマホアプリ。ヤフオクのAPIは当時廃止された直後でスクレイピングで頑張った。Xamarin.Formsのおかげでかなり楽に実装できた。",
                "C#, Xamarin.Forms, Prism(UI)", "スマホアプリ",
                @"", @"https://github.com/nobu17/YahooAuctionReminder",
                @"image/portfolio/shop.svg",
                new List<string>() { @"image/portfolio/noimage.png" }));

            works.Add(new WorkItem("1", "ISBN Book Titler", "本の自炊時のリネームツール",
                "初めて作成したフリーソフト。ScanSnap等で電子化した書籍のバーコードから書籍情報を取得してリネームを行うツール。多くの人に使っていただけているようで、バグ報告や要望等がよく来ていた。MACでも動くようにelectronで作り直しを考えたが計画止まりとなっている。",
                "C#, WPF", "ローカルアプリ",
                @"http://nobunobu1717.site/?p=805", @"https://github.com/nobu17/ISBNBookTitler",
                @"image/portfolio/bookt3.png",
                new List<string>() { @"image/portfolio/isbn1.png" }));

            return works;
        }
    }
}
