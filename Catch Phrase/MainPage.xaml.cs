using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Catch_Phrase
{
    public partial class MainPage : PhoneApplicationPage
    {
        string[] phrases_list = { "whatever", "buddy", "sip", "chicken coop", "blur", "chime", "bleach", "clay", "blossom", "cog", "twitterpated", "wish", "through", "feudalism", "whiplash", "cot", "blueprint", "beanstalk", "think", "cardboard", "darts", "inn", "Zen", "crow's nest", "BFF", "sheriff", "tiptop", "dot", "bob", "garden hose", "blimp", "dress shirt", "reimbursement", "capitalism", "step-daughter", "applause", "jig", "jade", "blunt", "application", "rag", "squint", "intern", "sow's  ear", "brainstorm", "sling", "half", "pinch", "leak", "skating rink", "jog", "jammin'", "shrink ray", "dent", "scoundrel", "escalator", "cell phone charger", "kitchen knife set", "sequins", "ladder rung", "", "flu", "scuff mark", "mast", "sash", "modern", "ginger", "clockwork", "mess", "mascot", "runt", "chain", "scar tissue", "suntan", "pomp", "scramble", "sentence", "first mate", "cuff", "cuticle", "fortnight", "riddle", "spool", "full moon", "forever", "rut", "hem", "new", "freight train", "diver", "fringe", "humidifier", "handwriting", "dawn", "dimple", "gray hairs", "hedge", "plank", "race", "publisher", "fizz", "gem", "ditch", "wool", "plaid", "fancy", "ebony and ivory", "feast", "Murphy's Law", "billboard", "flush", "inconceivable", "tide", "midsummer", "population", "my", "elm", "organ", "flannel", "hatch", "booth", "sandwich", "kumquat", "black beans", "spatula", "pizza", "zest", "cheese", "tempura", "ice cream sundae", "rolling pin", "egg salad", "artichoke", "grape", "à la carte", "milk", "banana split", "boiled egg", "soup de jour", "Taco  Bell", "lasagna", "toaster", "soft pretzel", "bread", "jellybeans", "mac and cheese", "mushroom", "cupcakes", "apple pie", "wok", "oven mitt", "corn", "avocado", "egg timer", "muffin tin", "whisk", "dairy", "potato chips", "sun-dried tomatoes", "granola bar", "sea salt", "poultry", "noodles", "lemon zester", "banana", "simmer", "freeze", "blender", "cornbread", "produce", "salt shaker", "Dutch oven", "poach", "apple", "Balsamic vinegar", "shish kabob", "sifter", "meatballs", "pear", "Canadian bacon", "sushi", "melt", "napkin", "colander", "baking soda", "all-you-can-eat buffet", "toaster oven", "BLT", "cinnamon rolls", "caviar", "wooden spoon", "dredge", "bagel", "beef", "pork", "deep-fry", "bake", "guacamole", "banana bread", "fork", "grill", "low-fat", "vanilla extract", "broil", "fruit smoothie", "waffles", "marinade", "chicken pot  pie", "baked Alaska", "bread bowl", "beef jerky", "crepe", "blackberry", "drive-through", "fruit salad", "flambé", "sweet potatoes", "McDonalds", "Alfredo sauce", "Burger King", "taco", "popcorn", "pancakes", "basil", "Bavarian cream", "Pop Tart", "KFC", "spinach", "key lime pie", "appetizer", "s'mores", "cutting board", "egg nog", "chocolate cake", "broth", "doughnuts", "blanch", "hot dogs", "Bundt pan", "frying pan", "Kool-aid", "tuba", "singer", "race", "candy", "student", "day", "jump", "hurt", "laundry", "blue", "sad", "old", "guitar", "athlete", "night", "knee", "wedding", "bat", "buy", "trash can", "freckle", "stream", "quiet", "mop", "swing", "radio", "square", "Monday", "school bus", "poem", "scared", "draw", "type", "short", "stairs", "asleep", "motorcycle", "lunch", "fog", "new", "straw", "push", "dirty", "girl", "helicopter", "playground", "tiger", "tornado", "lime", "leg", "salt", "ankle", "cake", "shoelace", "wheelchair", "goodbye", "worm", "eyebrow", "lion", "pear", "talk", "glasses", "shirt", "spoon", "box", "wind", "green", "wolf", "snow", "couch", "fix", "flashlight", "princess", "broken", "dictionary", "plate", "neighbor", "roller coaster", "bridge", "mailbox", "flower", "white", "sandcastle", "triangle", "thunder", "monster", "long", "lizard", "cafeteria", "music", "fire engine", "star", "cook", "tired", "slow", "outer space", "brave", "horse", "niece", "elephant", "tractor", "elevator", "light bulb", "broccoli", "cough", "heart", "calculator", "stick", "cat", "tree house", "watermelon", "chocolate", "bird's nest", "fast", "hungry", "red", "frown", "chew", "pepper", "sick", "panda", "housecat", "moth", "moose", "water buffalo", "caterpillar", "albatross", "duck", "mouse", "salamander", "Canadian goose", "rat", "aardvark", "joey", "robin", "horse", "koala", "black bear", "hippopotamus", "camel", "cougar", "giraffe", "bald eagle", "crocodile", "dog", "bird", "penguin", "pony", "bat", "otter", "porcupine", "dolphin", "hamster", "chameleon", "swordfish", "groundhog", "cricket", "clownfish", "gila monster", "leopard", "rabbit", "buffalo", "shark", "stallion", "wombat", "kitten", "reindeer", "wolf", "dragon", "blue whale", "hyena", "unicorn", "tuna", "platypus", "basset hound", "shrimp", "skunk", "bulldog", "ladybug", "beaver", "puppy", "weasel", "owl", "chipmunk", "lamb", "tiger", "doe", "ewe", "pelican", "ape", "sheep dog", "partridge", "hedgehog", "cow", "spider", "turtle", "alligator", "seahorse", "sea turtle", "llama", "hive", "lion", "armadillo", "herd", "gopher", "three-toed sloth", "elk", "fox", "guinea pig", "sea lion", "donkey", "frog", "crow", "zebra", "toad", "worm", "panther", "chinchilla", "flock", "chimpanzee", "calf", "school of fish", "warthog", "cub", "seagull", "parakeet", "chicken", "human", "toucan", "deer", "lobster", "prairie dog", "dove", "walrus", "komodo dragon", "jellyfish", "crab", "tortoise", "duckling", "wasp", "squirrel", "wildebeest", "catfish" };
        
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Set the data context of the listbox control to the sample data
            DataContext = App.ViewModel;
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        // Load data for the ViewModel Items
        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
            }
        }

        private void startButtonClicked(object sender, RoutedEventArgs e)
        {
            Random rand = new Random();
            App.ViewModel.Phrase = String.Format("{0}", phrases_list[rand.Next(phrases_list.Length)]);
            App.ViewModel.SampleProperty = "this is a new string";
            NavigationService.Navigate(new Uri("/Test.xaml", UriKind.Relative));
        }
    }
}