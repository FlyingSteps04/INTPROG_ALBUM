using Microsoft.AspNetCore.Mvc;
using PhotoAlbum.Models;

namespace PhotoAlbum.Controllers
{
    public class AlbumController : Controller
    {
        // ── HOME ─────────────────────────────────────────────────────────────────
        public IActionResult Index()
        {
            var sections = new List<AlbumSection>
            {
                new() {
                    Name        = "Childhood",
                    Route       = "Childhood",
                    Description = "Precious early memories and the magic of growing up",
                    CoverImage  = "/media/Childhood/received_2389018004523468.jpeg",
                    Icon        = "🧸"
                },
                new() {
                    Name        = "Friends",
                    Route       = "Friends",
                    Description = "Laughter, bonding and the moments shared with those who matter most",
                    CoverImage  = "/media/Friends/received_1425964862298432.jpeg",
                    Icon        = "🤝"
                },
                new() {
                    Name        = "High School Era",
                    Route       = "School",
                    Description = "Classroom adventures, field trips and academic milestones",
                    CoverImage  = "/media/School/FB_IMG_4823374177006307699.jpg",
                    Icon        = "🎓"
                },
                new() {
                    Name        = "Sports",
                    Route       = "Sports",
                    Description = "Sweat, teamwork and the thrill of every game day",
                    CoverImage  = "/media/Sports/FB_IMG_2363939527781035951.jpg",
                    Icon        = "🏆"
                },
                new() {
                    Name        = "Student Life",
                    Route       = "Student",
                    Description = "Campus life, study sessions and the journey through student days",
                    CoverImage  = "/media/Student/FB_IMG_6536665866520643660.jpg",
                    Icon        = "📚"
                },
            };
            return View("Home", sections);
        }

        // ── CHILDHOOD ────────────────────────────────────────────────────────────
        public IActionResult Childhood()
        {
            var model = new AlbumPage
            {
                PageTitle    = "Childhood",
                PageSubtitle = "Precious early memories and the magic of growing up",
                HeroIcon     = "🧸",
                Media = new List<MediaItem>
                {
                    new() { Title = "Little Gatherings",        Description = "Going out to the beach with Wide eyed curiosity leading to the very first big adventures of childhood.", Src = "/media/Childhood/FB_IMG_3498233262170466443.jpg",   IsVideo = false },
                    new() { Title = "Gaming Time",            Description = "A favorite childhood moment spent lost in a game, enjoying every minute of playtime.", Src = "/media/Childhood/FB_IMG_4996829062036554198.jpg",   IsVideo = false },
                    new() { Title = "Sunny Afternoon",        Description = "A sudden trip towards nature with golden afternoon light capturing a carefree day of play and imagination.",  Src = "/media/Childhood/FB_IMG_6751585778290980499.jpg",   IsVideo = false },
                    new() { Title = "Roleplaying",   Description = "Simple roleplay in the backyard that felt like the grandest adventures ever.",       Src = "/media/Childhood/received_1043773072651940.jpeg",  IsVideo = false },
                    new() { Title = "School Shenanigans",           Description = "Vacant time to have weird pictures to entertain ourselves.", Src = "/media/Childhood/received_213840719891975.jpeg",   IsVideo = false },
                    new() { Title = "Cosplaying as Greek Gods",         Description = "An individual project to cosplay greek gods and goddesses.", Src = "/media/Childhood/received_2389018004523468.jpeg",  IsVideo = false },
                    new() { Title = "Holiday Memory",         Description = "A way to take a break from school and go to the beach with friends.",Src = "/media/Childhood/received_2550382668534654.jpeg",  IsVideo = false },
                    new() { Title = "Graduation Trip",         Description = "The last gathering before going separate ways to college.",      Src = "/media/Childhood/received_302628300717837.jpeg",   IsVideo = false },
                    new() { Title = "Nature",             Description = "A way to cool of due to brownout and admiring nature's habitats.",        Src = "/media/Childhood/received_3754019921524398.jpeg",  IsVideo = false },
                    new() { Title = "School redicule",          Description = "Spontaneous capture just piggyback riding for no reasons.",          Src = "/media/Childhood/received_557961948176000.jpeg",   IsVideo = false },
                    new() { Title = "Elementary Xmas Party",        Description = "Elementary xmas party just having fun and exchanging presents.",    Src = "/media/Childhood/received_617370612385310.jpeg",   IsVideo = false },
                    new() { Title = "School Extra Curricular Activities",        Description = "Doing extra curricular activities that contributes to society by giving donations to those in need.",       Src = "/media/Childhood/received_870079924835588.jpeg",   IsVideo = false },
                }
            };
            return View("GalleryPage", model);
        }

        // ── FRIENDS ──────────────────────────────────────────────────────────────
        public IActionResult Friends()
        {
            var model = new AlbumPage
            {
                PageTitle    = "Friends",
                PageSubtitle = "Laughter, bonding and the moments shared with those who matter most",
                HeroIcon     = "🤝",
                Media = new List<MediaItem>
                {
                    new() { Title = "Squad Goals",            Description = "The whole crew together every face a chapter in the story of friendship.", Src = "/media/Friends/FB_IMG_9106182792060604751.jpg",    IsVideo = false },
                    new() { Title = "Road Trip Vibes",        Description = "Windows down, music up a spontaneous road trip no one will ever forget.",   Src = "/media/Friends/received_139281975818102.jpeg",    IsVideo = false },
                    new() { Title = "Beach Reunion",    Description = "Nothing beats a reunion in the sea, Long time no sea? but now sea now.",       Src = "/media/Friends/received_1425964862298432.jpeg",   IsVideo = false },
                    new() { Title = "Wandering Around",        Description = "A planned takeaway to escape from stress and schoolworks.",      Src = "/media/Friends/received_1629727984204497.jpeg",   IsVideo = false },
                    new() { Title = "Choose your poison",           Description = "A simple gathering with some alcohol pass the time.",      Src = "/media/Friends/received_1887683025003186.jpeg",   IsVideo = false },
                    new() { Title = "Barangay Fiesta",              Description = "A feastive celebration and some karaoke.",          Src = "/media/Friends/received_2679390292263705.jpeg",   IsVideo = false },
                    new() { Title = "Xmas Party",       Description = "Raising a toast to the friendships that make life worth celebrating.",           Src = "/media/Friends/received_3940937039517342.jpeg",   IsVideo = false },
                    new() { Title = "Candid Moment",          Description = "Unscripted, unposed — just real people having a genuinely great time.",         Src = "/media/Friends/received_473433292448559.jpeg",    IsVideo = false },
                    new() { Title = "Feastive Celebration",       Description = "A memorable fiesta packed with food and guests.",          Src = "/media/Friends/received_648633783425512.jpeg",    IsVideo = false },
                    new() { Title = "Birthday Celebration",          Description = "Birthday celebration with unforgettable memories and tasty dishes.",       Src = "/media/Friends/received_786201890608073.jpeg",    IsVideo = false },
                    new() { Title = "Beach Vacation",    Description = "After a long academic study, nothing beats a beach gathering.",    Src = "/media/Friends/received_881386653774958.jpeg",    IsVideo = false },
                    new() { Title = "Fun Clip",               Description = "Caught on video  a hilarious and heartwarming moment with the whole group.",    Src = "/media/Friends/FB_VID_3029975875464115010.mp4",   IsVideo = true  },
                    new() { Title = "Together Again",         Description = "No matter how long apart, getting back together always feels like coming home.", Src = "/media/Friends/FB_VID_6425747435246159290.mp4",   IsVideo = true  },
                }
            };
            return View("GalleryPage", model);
        }

        // ── SCHOOL ───────────────────────────────────────────────────────────────
        public IActionResult School()
        {
            var model = new AlbumPage
            {
                PageTitle    = "High School Era",
                PageSubtitle = "Classroom adventures, field trips and academic milestones",
                HeroIcon     = "🎓",
                Media = new List<MediaItem>
                {
                    new() { Title = "Classroom Days",         Description = "Rows of desks, the smell of markers and lessons that shaped who we became.",      Src = "/media/School/FB_IMG_2234242176308419362.jpg",    IsVideo = false },
                    new() { Title = "School Event",         Description = "After a tiring participation for a competetitve advantage and take home the bacon, a memorable day to be remembered and taken.", Src = "/media/School/FB_IMG_3551673224683623273.jpg",    IsVideo = false },
                    new() { Title = "Drum, Lyre, Bugle corps",           Description = "A school parade around the barangay for a feastive and awaited event.",        Src = "/media/School/FB_IMG_4823374177006307699.jpg",    IsVideo = false },
                    new() { Title = "Study Group",            Description = "Late afternoons surrounded by books, notes and determined classmates.",          Src = "/media/School/FB_IMG_4866695692006023079.jpg",    IsVideo = false },
                    new() { Title = "Graduation Pride",       Description = "The moment all those early mornings and late nights finally paid off.",          Src = "/media/School/FB_IMG_5333770827904305666.jpg",    IsVideo = false },
                    new() { Title = "School Portrait",        Description = "A formal photo that holds an informal flood of cherished memories.",             Src = "/media/School/FB_IMG_581952131164059465.jpg",     IsVideo = false },
                    new() { Title = "Classroom Jersey",          Description = "An agreement to make jersey for the class itself.",                 Src = "/media/School/FB_IMG_8159244699476143014.jpg",    IsVideo = false },
                    new() { Title = "Award Ceremony",         Description = "Recognition for hard work, dedication and the pursuit of excellence.",           Src = "/media/School/FB_IMG_8519010991302199386.jpg",    IsVideo = false },
                    new() { Title = "Campus Corner",          Description = "A quiet corner of campus where great ideas and deep friendships were born.",      Src = "/media/School/received_3652227295074576.jpeg",    IsVideo = false },
                    new() { Title = "Research Defense",            Description = "Pressurized by questions, conquered by knowledge. A succesful day defending academic studies.",             Src = "/media/School/received_420603057240427.jpeg",     IsVideo = false },
                    new() { Title = "Project Showcase",       Description = "Weeks of hard work proudly on display for teachers, parents and peers.",         Src = "/media/School/received_504639528498776.jpeg",     IsVideo = false },
                    new() { Title = "Recognition of Honors",          Description = "Veni, Vidi, Vici!.",     Src = "/media/School/received_689454468188808.jpeg",     IsVideo = false },
                    new() { Title = "Graduation Pictorial",           Description = "The chaos of the final bell and pursuit of academic excellence.",            Src = "/media/School/received_814714652924086.jpeg",     IsVideo = false },
                    new() { Title = "Year End Party",         Description = "Celebrating another year survived with friends who made it all worthwhile.",     Src = "/media/School/received_958801408486200.jpeg",     IsVideo = false },
                    new() { Title = "UC JONES CAMPUS",          Description = "A captivating architecture of the new building.",   Src = "/media/School/FB_VID_3846638093491160043.mp4",    IsVideo = true  },
                    new() { Title = "Breadboard",          Description = "The curiousity that lead to LED's.",         Src = "/media/School/FB_VID_3861351267242037739.mp4",    IsVideo = true  },
                    new() { Title = "BREADBOARD MATRIX",          Description = "A complex task of DIGILOG yet conquered for the pursuit of knowledge and grades.",           Src = "/media/School/FB_VID_5723711317654183113.mp4",    IsVideo = true  },
                }
            };
            return View("GalleryPage", model);
        }

        // ── SPORTS ───────────────────────────────────────────────────────────────
        public IActionResult Sports()
        {
            var model = new AlbumPage
            {
                PageTitle    = "Sports",
                PageSubtitle = "Sweat, teamwork and the thrill of every game day",
                HeroIcon     = "🏆",
                Media = new List<MediaItem>
                {
                    new() { Title = "Game Day",               Description = "The electricity in the air right before the opening whistle — pure anticipation.", Src = "/media/Sports/FB_IMG_1791515263571.jpg",          IsVideo = false },
                    new() { Title = "Team Photo",             Description = "Every championship begins with a team that believes in each other.",              Src = "/media/Sports/FB_IMG_1791515665373.jpg",          IsVideo = false },
                    new() { Title = "UC DAYS",              Description = "Bodies moving at full speed, chasing victory one play at a time.",                Src = "/media/Sports/FB_IMG_2363939527781035951.jpg",    IsVideo = false },
                    new() { Title = "Training",           Description = "Striving greatness with hardwork, practice makes perfections.",        Src = "/media/Sports/FB_IMG_7880427325367413970.jpg",    IsVideo = false },
                    new() { Title = "Self Training",          Description = "Early mornings, sore muscles and the relentless pursuit of being better.",        Src = "/media/Sports/FB_VID_1733702688791372153.mp4",    IsVideo = true  },
                    new() { Title = "Match Highlights",       Description = "The best plays of the day condensed into one unforgettable highlight reel.",      Src = "/media/Sports/FB_VID_2103297519418075627.mp4",    IsVideo = true  },
                    new() { Title = "Racket Build",         Description = "Building a racket from custom parts.",       Src = "/media/Sports/FB_VID_3592848323120435872.mp4",    IsVideo = true  },
                    new() { Title = "CHESS",            Description = "A strategic game for the minds.",        Src = "/media/Sports/FB_VID_5865983288988089975.mp4",    IsVideo = true  },
                    new() { Title = "Comeback Moment",        Description = "Down but not out — the dramatic rally that had everyone on their feet.",          Src = "/media/Sports/FB_VID_6211906329804544318.mp4",    IsVideo = true  },
                    new() { Title = "Pre-Game Hype",          Description = "The energy before the match: stretches, rallying cries and focused faces.",       Src = "/media/Sports/FB_VID_7311455369928473043.mp4",    IsVideo = true  },
                    new() { Title = "Post-Game Celebration",  Description = "The final whistle, the celebration and the exhausted smiles of a job well done.", Src = "/media/Sports/FB_VID_8028863292311122485.mp4",    IsVideo = true  },
                    new() { Title = "Full Match Video",       Description = "The complete match from kick-off to final score — a game nobody wanted to miss.", Src = "/media/Sports/VID_20260926_192752.mp4",           IsVideo = true  },
                }
            };
            return View("GalleryPage", model);
        }

        // ── STUDENT ──────────────────────────────────────────────────────────────
        public IActionResult Student()
        {
            var model = new AlbumPage
            {
                PageTitle    = "Student Life",
                PageSubtitle = "Campus life, study sessions and the journey through student days",
                HeroIcon     = "📚",
                Media = new List<MediaItem>
                {
                    new() { Title = "Campus Life",            Description = "Photo deserved taken after a hard fought battle to complete the project.",   Src = "/media/Student/FB_IMG_3865851803263789278.jpg",   IsVideo = false },
                    new() { Title = "Ridicule with Classmates",       Description = "A snapshot of love towards our peers.",  Src = "/media/Student/FB_IMG_5137615632471450349.jpg",   IsVideo = false },
                    new() { Title = "University Days",        Description = "The years that shaped life, passions and lifelong friendships all at once.",    Src = "/media/Student/FB_IMG_6536665866520643660.jpg",   IsVideo = false },
                    new() { Title = "Recognition",       Description = "The reward of knowledge recognized by your peers.", Src = "/media/Student/FB_IMG_7377861604506803632.jpg",   IsVideo = false },
                    new() { Title = "THESIS",          Description = "Surrounded by knowledge, fuelled by coffee and powered by sheer determination.",  Src = "/media/Student/received_597212495635430.jpeg",    IsVideo = false },
                    new() { Title = "FEASTIVE EVENT",            Description = "A lively competition of all class, striving first place a well deserved photo after a hard work.", Src = "/media/Student/received_771396354151964.jpeg",    IsVideo = false },
                    new() { Title = "Xmas Party",       Description = "A lively xmas party with jolly chants and gifts.",     Src = "/media/Student/received_868419317620967.jpeg",    IsVideo = false },
                    new() { Title = "Student Retreat",      Description = "A silent battle of understanding one's self, seeking the meaning of life and purpose.",    Src = "/media/Student/received_964103768078440.jpeg",    IsVideo = false },
                }
            };
            return View("GalleryPage", model);
        }
    }
}
