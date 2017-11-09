using Newtonsoft.Json;

namespace BlackJackGame.Models {
    [JsonObject(MemberSerialization.OptIn)]
    public class Card {

        #region Properties
        [JsonProperty]
        public FaceValue FaceValue { get; private set; }
        [JsonProperty]
        public Suit Suit { get; private set; }
        #endregion

        #region Constructors
        public Card(Suit suit, FaceValue faceValue) {
            Suit = suit;
            FaceValue = faceValue;
        }
        #endregion

        }       
    }
