using UnityEngine;
using System.Collections;

public class ResourceNameRomaji : MonoBehaviour {

	public static string ResToRomaji(string resName){
		string romaji;

		switch (resName){

			/////HIRAGANA BASE/////
			case "HiraganaBase_wOnigiri_0":
				romaji = "a"; break;
			case "HiraganaBase_wOnigiri_1":
				romaji = "i"; break;
			case "HiraganaBase_wOnigiri_2":
				romaji = "u"; break;
			case "HiraganaBase_wOnigiri_3":
				romaji = "e"; break;
			case "HiraganaBase_wOnigiri_4":
				romaji = "o"; break;
			case "HiraganaBase_wOnigiri_5":
				romaji = "ka"; break;
			case "HiraganaBase_wOnigiri_6":
				romaji = "ki"; break;
			case "HiraganaBase_wOnigiri_7":
				romaji = "ku"; break;
			case "HiraganaBase_wOnigiri_8":
				romaji = "ke"; break;
			case "HiraganaBase_wOnigiri_9":
				romaji = "ko"; break;
			case "HiraganaBase_wOnigiri_10":
				romaji = "sa"; break;
			case "HiraganaBase_wOnigiri_11":
				romaji = "shi"; break;
			case "HiraganaBase_wOnigiri_12":
				romaji = "su"; break;
			case "HiraganaBase_wOnigiri_13":
				romaji = "se"; break;
			case "HiraganaBase_wOnigiri_14":
				romaji = "so"; break;
			case "HiraganaBase_wOnigiri_15":
				romaji = "ta"; break;
			case "HiraganaBase_wOnigiri_16":
				romaji = "chi"; break;
			case "HiraganaBase_wOnigiri_17":
				romaji = "tsu"; break;
			case "HiraganaBase_wOnigiri_18":
				romaji = "te"; break;
			case "HiraganaBase_wOnigiri_19":
				romaji = "to"; break;
			case "HiraganaBase_wOnigiri_20":
				romaji = "na"; break;
			case "HiraganaBase_wOnigiri_21":
				romaji = "ni"; break;
			case "HiraganaBase_wOnigiri_22":
				romaji = "nu"; break;
			case "HiraganaBase_wOnigiri_23":
				romaji = "ne"; break;
			case "HiraganaBase_wOnigiri_24":
				romaji = "no"; break;
			case "HiraganaBase_wOnigiri_25":
				romaji = "ha"; break;
			case "HiraganaBase_wOnigiri_26":
				romaji = "hi"; break;
			case "HiraganaBase_wOnigiri_27":
				romaji = "fu"; break;
			case "HiraganaBase_wOnigiri_28":
				romaji = "he"; break;
			case "HiraganaBase_wOnigiri_29":
				romaji = "ho"; break;
			case "HiraganaBase_wOnigiri_30":
				romaji = "ma"; break;
			case "HiraganaBase_wOnigiri_31":
				romaji = "mi"; break;
			case "HiraganaBase_wOnigiri_32":
				romaji = "mu"; break;
			case "HiraganaBase_wOnigiri_33":
				romaji = "me"; break;
			case "HiraganaBase_wOnigiri_34":
				romaji = "mo"; break;
			case "HiraganaBase_wOnigiri_35":
				romaji = "ya"; break;
			case "HiraganaBase_wOnigiri_36":
				romaji = "yu"; break;
			case "HiraganaBase_wOnigiri_37":
				romaji = "yo"; break;
			case "HiraganaBase_wOnigiri_38":
				romaji = "ra"; break;
			case "HiraganaBase_wOnigiri_39":
				romaji = "ri"; break;
			case "HiraganaBase_wOnigiri_40":
				romaji = "ru"; break;
			case "HiraganaBase_wOnigiri_41":
				romaji = "re"; break;
			case "HiraganaBase_wOnigiri_42":
				romaji = "ro"; break;
			case "HiraganaBase_wOnigiri_43":
				romaji = "wa"; break;
			case "HiraganaBase_wOnigiri_44":
				romaji = "wo"; break;
			case "HiraganaBase_wOnigiri_45":
				romaji = "n"; break;
			case "HiraganaBase_wOnigiri_46":
				romaji = "ga"; break;
			case "HiraganaBase_wOnigiri_47":
				romaji = "gi"; break;
			case "HiraganaBase_wOnigiri_48":
				romaji = "gu"; break;
			case "HiraganaBase_wOnigiri_49":
				romaji = "ge"; break;
			case "HiraganaBase_wOnigiri_50":
				romaji = "go"; break;
			case "HiraganaBase_wOnigiri_51":
				romaji = "za"; break;
			case "HiraganaBase_wOnigiri_52":
				romaji = "ji"; break;
			case "HiraganaBase_wOnigiri_53":
				romaji = "zu"; break;
			case "HiraganaBase_wOnigiri_54":
				romaji = "ze"; break;
			case "HiraganaBase_wOnigiri_55":
				romaji = "zo"; break;
			case "HiraganaBase_wOnigiri_56":
				romaji = "da"; break;
			case "HiraganaBase_wOnigiri_57":
				romaji = "di"; break;
			case "HiraganaBase_wOnigiri_58":
				romaji = "du"; break;
			case "HiraganaBase_wOnigiri_59":
				romaji = "de"; break;
			case "HiraganaBase_wOnigiri_60":
				romaji = "do"; break;
			case "HiraganaBase_wOnigiri_61":
				romaji = "ba"; break;
			case "HiraganaBase_wOnigiri_62":
				romaji = "bi"; break;
			case "HiraganaBase_wOnigiri_63":
				romaji = "bu"; break;
			case "HiraganaBase_wOnigiri_64":
				romaji = "be"; break;
			case "HiraganaBase_wOnigiri_65":
				romaji = "bo"; break;
			case "HiraganaBase_wOnigiri_66":
				romaji = "pa"; break;
			case "HiraganaBase_wOnigiri_67":
				romaji = "pi"; break;
			case "HiraganaBase_wOnigiri_68":
				romaji = "pu"; break;
			case "HiraganaBase_wOnigiri_69":
				romaji = "pe"; break;
			case "HiraganaBase_wOnigiri_70":
				romaji = "po"; break;

			//////COMPOSED//////
			case "1-Kya":
				romaji = "kya"; break;
			case "2-Kyu":
				romaji = "kyu"; break;
			case "3-Kyo":
				romaji = "kyo"; break;
			case "4-Sha":
				romaji = "sha"; break;
			case "5-Shu":
				romaji = "shu"; break;
			case "6-Sho":
				romaji = "sho"; break;
			case "7-Cha":
				romaji = "cha"; break;
			case "8-Chu":
				romaji = "chu"; break;
			case "9-Cho":
				romaji = "cho"; break;
			case "10-Nya":
				romaji = "nya"; break;
			case "11-Nyu":
				romaji = "nyu"; break;
			case "12-Nyo":
				romaji = "nyo"; break;
			case "13-Hya":
				romaji = "hya"; break;
			case "14-Hyu":
				romaji = "hyu"; break;
			case "15-Hyo":
				romaji = "hyo"; break;
			case "16-Mya":
				romaji = "mya"; break;
			case "17-Myu":
				romaji = "myu"; break;
			case "18-Myo":
				romaji = "myo"; break;
			case "19-Rya":
				romaji = "rya"; break;
			case "20-Ryu":
				romaji = "ryu"; break;
			case "21-Ryo":
				romaji = "ryo"; break;
			case "22-Gya":
				romaji = "gya"; break;
			case "23-Gyu":
				romaji = "gyu"; break;
			case "24-Gyo":
				romaji = "gyo"; break;
			case "25-Ja":
				romaji = "ja"; break;
			case "26-Ju":
				romaji = "ju"; break;
			case "27-Jo":
				romaji = "jo"; break;
			case "28-Bya":
				romaji = "bya"; break;
			case "29-Byu":
				romaji = "byu"; break;
			case "30-Byo":
				romaji = "byo"; break;
			case "31-Pya":
				romaji = "pya"; break;
			case "32-Pyu":
				romaji = "pyu"; break;
			case "33-Pyo":
				romaji = "pyo"; break;

			/////KATAKANA BASE/////
			case "KatakanaBase_wOnigiri_0":
				romaji = "a"; break;
			case "KatakanaBase_wOnigiri_1":
				romaji = "i"; break;
			case "KatakanaBase_wOnigiri_2":
				romaji = "u"; break;
			case "KatakanaBase_wOnigiri_3":
				romaji = "e"; break;
			case "KatakanaBase_wOnigiri_4":
				romaji = "o"; break;
			case "KatakanaBase_wOnigiri_5":
				romaji = "ka"; break;
			case "KatakanaBase_wOnigiri_6":
				romaji = "ki"; break;
			case "KatakanaBase_wOnigiri_7":
				romaji = "ku"; break;
			case "KatakanaBase_wOnigiri_8":
				romaji = "ke"; break;
			case "KatakanaBase_wOnigiri_9":
				romaji = "ko"; break;
			case "KatakanaBase_wOnigiri_10":
				romaji = "sa"; break;
			case "KatakanaBase_wOnigiri_11":
				romaji = "shi"; break;
			case "KatakanaBase_wOnigiri_12":
				romaji = "su"; break;
			case "KatakanaBase_wOnigiri_13":
				romaji = "se"; break;
			case "KatakanaBase_wOnigiri_14":
				romaji = "so"; break;
			case "KatakanaBase_wOnigiri_15":
				romaji = "ta"; break;
			case "KatakanaBase_wOnigiri_16":
				romaji = "chi"; break;
			case "KatakanaBase_wOnigiri_17":
				romaji = "tsu"; break;
			case "KatakanaBase_wOnigiri_18":
				romaji = "te"; break;
			case "KatakanaBase_wOnigiri_19":
				romaji = "to"; break;
			case "KatakanaBase_wOnigiri_20":
				romaji = "na"; break;
			case "KatakanaBase_wOnigiri_21":
				romaji = "ni"; break;
			case "KatakanaBase_wOnigiri_22":
				romaji = "nu"; break;
			case "KatakanaBase_wOnigiri_23":
				romaji = "ne"; break;
			case "KatakanaBase_wOnigiri_24":
				romaji = "no"; break;
			case "KatakanaBase_wOnigiri_25":
				romaji = "ha"; break;
			case "KatakanaBase_wOnigiri_26":
				romaji = "hi"; break;
			case "KatakanaBase_wOnigiri_27":
				romaji = "fu"; break;
			case "KatakanaBase_wOnigiri_28":
				romaji = "he"; break;
			case "KatakanaBase_wOnigiri_29":
				romaji = "ho"; break;
			case "KatakanaBase_wOnigiri_30":
				romaji = "ma"; break;
			case "KatakanaBase_wOnigiri_31":
				romaji = "mi"; break;
			case "KatakanaBase_wOnigiri_32":
				romaji = "mu"; break;
			case "KatakanaBase_wOnigiri_33":
				romaji = "me"; break;
			case "KatakanaBase_wOnigiri_34":
				romaji = "mo"; break;
			case "KatakanaBase_wOnigiri_35":
				romaji = "ya"; break;
			case "KatakanaBase_wOnigiri_36":
				romaji = "yu"; break;
			case "KatakanaBase_wOnigiri_37":
				romaji = "yo"; break;
			case "KatakanaBase_wOnigiri_38":
				romaji = "ra"; break;
			case "KatakanaBase_wOnigiri_39":
				romaji = "ri"; break;
			case "KatakanaBase_wOnigiri_40":
				romaji = "ru"; break;
			case "KatakanaBase_wOnigiri_41":
				romaji = "re"; break;
			case "KatakanaBase_wOnigiri_42":
				romaji = "ro"; break;
			case "KatakanaBase_wOnigiri_43":
				romaji = "wa"; break;
			case "KatakanaBase_wOnigiri_44":
				romaji = "wo"; break;
			case "KatakanaBase_wOnigiri_45":
				romaji = "n"; break;
			case "KatakanaBase_wOnigiri_46":
				romaji = "ga"; break;
			case "KatakanaBase_wOnigiri_47":
				romaji = "gi"; break;
			case "KatakanaBase_wOnigiri_48":
				romaji = "gu"; break;
			case "KatakanaBase_wOnigiri_49":
				romaji = "ge"; break;
			case "KatakanaBase_wOnigiri_50":
				romaji = "go"; break;
			case "KatakanaBase_wOnigiri_51":
				romaji = "za"; break;
			case "KatakanaBase_wOnigiri_52":
				romaji = "ji"; break;
			case "KatakanaBase_wOnigiri_53":
				romaji = "zu"; break;
			case "KatakanaBase_wOnigiri_54":
				romaji = "ze"; break;
			case "KatakanaBase_wOnigiri_55":
				romaji = "zo"; break;
			case "KatakanaBase_wOnigiri_56":
				romaji = "da"; break;
			case "KatakanaBase_wOnigiri_57":
				romaji = "di"; break;
			case "KatakanaBase_wOnigiri_58":
				romaji = "du"; break;
			case "KatakanaBase_wOnigiri_59":
				romaji = "de"; break;
			case "KatakanaBase_wOnigiri_60":
				romaji = "do"; break;
			case "KatakanaBase_wOnigiri_61":
				romaji = "ba"; break;
			case "KatakanaBase_wOnigiri_62":
				romaji = "bi"; break;
			case "KatakanaBase_wOnigiri_63":
				romaji = "bu"; break;
			case "KatakanaBase_wOnigiri_64":
				romaji = "be"; break;
			case "KatakanaBase_wOnigiri_65":
				romaji = "bo"; break;
			case "KatakanaBase_wOnigiri_66":
				romaji = "pa"; break;
			case "KatakanaBase_wOnigiri_67":
				romaji = "pi"; break;
			case "KatakanaBase_wOnigiri_68":
				romaji = "pu"; break;
			case "KatakanaBase_wOnigiri_69":
				romaji = "pe"; break;
			case "KatakanaBase_wOnigiri_70":
				romaji = "po"; break;


			//////DEFAULT/////
			default:
				romaji = null; break;
		}

		return romaji;
	}
}
