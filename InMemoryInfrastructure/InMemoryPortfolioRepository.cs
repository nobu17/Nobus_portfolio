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

            var works = new List<WorkItem>();
            works.Add(new WorkItem("1", "Nobu's portfolio", "ポートフォリオサイト",
                "本サイト。Blazorを使って作成したポートフォリオサイトです。なんちゃってDDDで実装しています。",
                "C#,Blazor, MDBootstrap", "firebase",
                @"https://nobus-portfolio.web.app", @"https://github.com/nobu17/Nobus_portfolio",
                @"image/portfolio/kae1.svg",
                new List<string>() { @"image/portfolio/ptf1.png" }));

            works.Add(new WorkItem("2", "SURUGA-BU(駿河部)", "静岡県東部の紹介メディア",
                "Ruby on Railsの勉強を兼ねて作成したサイト。Blogをフルスクラッチで作成した形。記事の投稿はMarkdownにて記載する。Herokuの無料プランで運用中。",
                "Ruby on Rails", "Heroku, PostgresSQL, Redis, GCS",
                @"https://surugabu.com/", @"https://github.com/nobu17/surugabu/",
                @"image/portfolio/maguro.svg",
                new List<string>() { @"image/portfolio/surugabu1.png" }));

            works.Add(new WorkItem("3", "AngularBookSearch", "古本価格調査サイト",
                "個人的な趣味の古本購入時のツールとして開発。Angularを使用。APIはAWS LambdaでGrapghQLで作成。",
                "Typescript, Angular, PrimeNG(WEB-UI), Node.js(API)", "firebase, AWS(Lambda, API Gateway)",
                @"https://angularbooksearch.web.app/", @"https://github.com/nobu17/AngularBookScanApp/",
                @"image/portfolio/bookt3.png",
                new List<string>() { @"image/portfolio/angb1.png", @"image/portfolio/angb2.png", @"image/portfolio/angb3.png" }));

            works.Add(new WorkItem("4", "CHICO★SPICE", "カレーショップ",
                "知り合いのお店をNuxt.jsの勉強を兼ねて作成。Auth0の認証なども組み込んでいます。",
                "Nuxt.js, Vue.js, Vuetify", "firebase(Hosting, Store, Authentication, Storage),Auth0,",
                @"https://chico-sp-website.web.app/", @"https://github.com/nobu17/chiko_sp",
                @"image/portfolio/chiko.png",
                new List<string>() { @"image/portfolio/chico1.png", @"image/portfolio/chico2.png" }));

            works.Add(new WorkItem("5", "Braidal Quiz", "リアルタイム集計クイズ",
                "結婚式の余興のために作成。firebase storeを使用してリアルタイムの集計を実施して、回答状況を可視化しました。",
                "Nuxt.js, Vue.js, Vuetify", "firebase(Hosting, Store, Storage),",
                @"", @"https://github.com/nobu17/bridal_quiz",
                @"image/portfolio/marrage1.svg",
                new List<string>() { @"image/portfolio/brd1.png", @"image/portfolio/brd2.png" }));

            works.Add(new WorkItem("6", "ItemObserveApp", "古本価格監視アプリ",
                "個人的な趣味の古本購入時のツールとしてXamarin.Formsで開発。APIはAWS Lambda上にGo言語で作成。15分間隔で価格を監視して、閾値が下がったらメールにて通知する。",
                "C#, Xamarin.Forms, Prism(UI), Go(API)", "スマホアプリ、AWS(Cognito, Lambda, API Gateway, SQS, SNS)",
                @"", @"https://github.com/nobu17/ItemObserveApp",
                @"image/portfolio/book2.svg",
                new List<string>() { @"image/portfolio/noimage.png" }));

            works.Add(new WorkItem("7", "fujimusic", "ギター教室",
                "私も参加しているギター教室。初めてVue.jsで本格的に作成したWEBサイト。",
                "Vue.js, Vuetify", "firebase(Hosting, Functions, Authentication, Storage),",
                @"https://fujimusicpj.web.app/", @"https://github.com/nobu17/fujimusic",
                @"image/portfolio/guitar1.svg",
                new List<string>() { @"image/portfolio/fuji1.png" }));

            works.Add(new WorkItem("6", "YahooAuctionReminder", "ヤフオク監視アプリ",
                "当時利用していたヤフオクで入札忘れが多く、防止のために終了5分前くらいに通知してくれるスマホアプリ。ヤフオクのAPIは当時廃止された直後でスクレイピングで頑張った。Xamarin.Formsのおかげでかなり楽に実装できた。",
                "C#, Xamarin.Forms, Prism(UI)", "スマホアプリ",
                @"", @"https://github.com/nobu17/YahooAuctionReminder",
                @"image/portfolio/shop.svg",
                new List<string>() { @"image/portfolio/noimage.png" }));

            works.Add(new WorkItem("7", "ISBN Book Titler", "本の自炊時のリネームツール",
                "初めて作成したフリーソフト。ScanSnap等でPDF等に電子化したファイルをバーコードから書籍情報を取得してリネーム等を行うツール。色々な人に使っていただけているようです。",
                "C#, WPF", "ローカルアプリ",
                @"http://nobunobu1717.site/?p=805", @"https://github.com/nobu17/ISBNBookTitler",
                @"image/portfolio/bookt3.png",
                new List<string>() { @"image/portfolio/isbn1.png" }));

            var folio = new Portfolio("1", works);

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
    }
}