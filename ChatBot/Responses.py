def sample_responses(input_text):
    user_message = input_text.strip(".?,-").split()
    # ***************** micsaleniuos ******************



    # **************** Outside Room *******************
    if any(x in user_message for x in
           ["קוד", "הקוד", "לקוד", "קוד", "הקוד", "לססמה", "ססמה", "הססמה", "סיסמה", "הסיסמה", "סיסמה", "הסיסמה"
               , "הססמא", "צופן", "צופן", "הצופן", "ססמא", "סיסמא", "סיסמא", "לסיסמא", "לסיסמא", "הסיסמא", "הסיסמא"
               , "הססמא", "ססמא", "הססמא"]):
        return PasswordInText(user_message)

    if any(x in user_message for x in
           ["דלת", "דלת", "לדלת", "לדלת", "הדלת", "הדלת", "דירה", "דירה", "הדירה", "לדירה", "לדירה"]):
        return EntranceInText(user_message)

    if any(x in user_message for x in
           ["גרפיטי", "ציורים", "ספריי", "צבוע", "צבועים", "ציור", "הגרפיטי", "הציורים", "הספריי", "הצבוע", "הצבועים",
            "הציור"]):
        return GraffitiInText(user_message)

    if any(x in user_message for x in
           ["אופניים", "האופניים", "לאופניים", "אופנוע", "לאופנוע", "האופנוע"]):
        return "אחד מהדיירים תמיד משאיר אותו לא נעול מחוץ לבניין, הוא חושב שאף אחד לא יגנוב לו"

    if any(x in user_message for x in
           ["מנורה", "המנורה", "למנורה", "אור", "האור", "לאור", "פנס", "הפנס", "לפנס"]):
        return LampInText(user_message)

    # ******************* Lobby Room *******************

    if any(x in user_message for x in
           ["ארון", "הארון"]):
        return ClosetInText(user_message)

    if any(x in user_message for x in
           ["לוח", "מודעות","וועד"]):
        return "לא צריך להתייחס ללוח המודעות יש פה דיירים נפלאים"

    # ******************* Living Room *******************

    if any(x in user_message for x in
           ["צמח", "הצמחים","הצמח","צמחים","עציצים","העציצים","עציץ","העציץ","אגרטל","האגרטל","אגרטלים","האגרטלים"]):
        return "בטעות שחכתי להשקות אותם,אני בטוח שהם יחזרו לקדמותם צ'יק צ'ק"

    if any(x in user_message for x in
           ["טלוויזיה"]):
        return TVInText(user_message)

    if any(x in user_message for x in
           ["תקליטור", "דיוידי","DVD","נגן"]):
        return DVDInText(user_message)

    if any(x in user_message for x in
           ["טלפון", "פלפון","פלאפון"]):
        return PhoneInText(user_message)

    if any(x in user_message for x in
           ["מגזין", "המגזין","מגזינים","המגזינים","פרונוגרפיים","הפורנוגרפיים","פורנוגרפים","הפורנוגרפים","עירום","עירומים","עירומות","עירומה"]):
        return "חבר שלי שכח אתמול,מקווה שלא נגעת בהם..."

    if any(x in user_message for x in
           ["שידה", "השידה","מדף","המדף"]):
        return "משום מה לא יצא לי לשים בו דברים"

    # ******************* Kitchen *******************

    if any(x in user_message for x in
           ["מקרר", "המקרר","במקרר","למקרר"]):
        return FridgeInText(user_message)

    if any(x in user_message for x in
           ["כביסה", "הכביסה","בכביסה","לכביסה"]):
        return WashingInText(user_message)

    if any(x in user_message for x in
           ["פיוז", "הפיוז","לפיוז","לפיוס","הפיוס","פיוס"]):
        return FuseInText(user_message)

    if any(x in user_message for x in
           ["פיצה", "הפיצה","פיצות","הפיצות","לפיצה","בפיצה","לפיצות","בפיצות"]):
        return "אלו פיצות מחודש שעבר,הם עדיין טובים! אז לא לזרוק"

    if any(x in user_message for x in
           ["חלב", "החלב","בחלב","לחלב"]):
        return "זה חיקוי לתנובה,ממש זול האמת"

    if any(x in user_message for x in
           ["שימורים", "השמורים","לשימורים"]):
        return "מה מעניין אותך כל כך כבר בשימורים..."

    if any(x in user_message for x in
           ["תרופה", "תרופות","התרופה","התרופות","בתרופה","בתרופות","סם","הסם","סמים","הסמים","טבליות","הטבליות","לסמים","לטבליות","בטבליות"]):
        return DrugsInText(user_message)

    if any(x in user_message for x in
           ["פחית", "הפחית","פחיות","הפחיות","בפחית","בפחיות"]):
        return "מצטער על הבלאגן, אנקה אותם כשאגיע בקרוב"

    # ******************* Bed Room *******************

    if any(x in user_message for x in
           ["קופסא", "קופסאות","הקופסא","הקופסאות","אריזה","אריזות","האריזה","האריזה","בקופסא", "בקופסאות","לקופסא","לקופסאות",
            "באריזה","באריזות","לאריזה","לאריזה","משלוח","משלוחים","המשלוח","המשלוחים","במשלוח","במשלוחים","למשלוח","למשלוחים"]):
        return BoxInText(user_message)

    if any(x in user_message for x in
           ["מחשב", "המחשב", "במחשב", "למחשב", "לפטופ", "הלפטופ","בלפטופ","ללפטופ"]):
        return "בבקשה,לא לגעץ בלפטופ,שמורים שם דברים אישיים!"

    if any(x in user_message for x in
           ["תמונה", "התמונה", "בתמונה", "בפחיות"]):
        return "אממ,זוהי תמונה של אחותי"

    if any(x in user_message for x in
           ["מיטה", "המיטה", "למיטה", "במיטה"]):
        return BedInText(user_message)

    # ******************* Bathroom *******************

    if any(x in user_message for x in
           ["מראה", "המראה","במראה","למראה","ראי","הראי","בראי","לראי"]):
        return MirrorInText(user_message)

    if any(x in user_message for x in
           ["נר", "הנר","לנר","בנר","נרות","הנרות","לנרות","בנרות"]):
        return CandleInText(user_message)

    if any(x in user_message for x in
           ["שירותים", "השירותים","בשירותים","לשירותים","אסלה","האסלה","באסלה","לאסלה"]):
        return "כעעע יש כרגע בעיה בצנרת כך שהמים אינם זורמים, לכן קצת מסריח בשירותים"

    # ******************* No Answer *******************

    return "לא הבנתי אותך"


def PasswordInText(user_message):
    if any(x in user_message for x in
           ["דלת", "דלת", "לדלת", "לדלת", "הדלת", "הדלת", "בניין", "בניין", "הבנייין", "הבניין", "לבניין"
               , "לבניין", "כניסה", "כניסה", "הכניסה", "הכניסה", "לכניסה", "לכניסה", "בית", "בית", "לבית", "לבית"
               , "הבית", "הבית"]):
        return "הקוד לכניסה הוא 1976"

    if any(x in user_message for x in
           ["מחשב", "מחשב", "למחשב", "למחשב", "המחשב", "המחשב", "לפטופ", "לפטופ", "ללפטופ", "ללפוט", "הלפטופ"
               , "הלפטופ", "נייד", "נייד", "לנייד", "לנייד", "הנייד", "הנייד"]):
        return "קצת אישי שאגלה לך את הקוד למחשב :("

    if any(x in user_message for x in
           ["טלפון", "פלפון","פלאפון"]):
        return "הכל חידות אצלך אה, מה כבר הצפייה שאגיד 5 בתוך 5?"

    return "לא הבנתי על איזה קוד מדובר"


def EntranceInText(user_message):
    if any(x in user_message for x in
           ["פותח", "פותחת", "פותחים", "איזו", "איזה", "נעולה", "מפתח", "איפה", "נכנס", "נכנסת", "נכנסים", "מפתחות","המפתח"]):
        return "מתחת לשטיח יש מפתח לדירה,<:"

    if any(x in user_message for x in
           ["מדרגות", "ציורים","הציורים","המדרגות"]):
        return "אין לך מה לחפש שם,הדירה שלי על הקרקע"

    if any(x in user_message for x in
           ["קוד", "הקוד", "לקוד", "קוד", "הקוד", "לססמה", "ססמה", "הססמה", "סיסמה", "הסיסמה", "סיסמה", "הסיסמה"
               , "הססמא", "צופן", "צופן", "הצופן", "ססמא", "סיסמא", "סיסמא", "לסיסמא", "לסיסמא", "הסיסמא", "הסיסמא"
               , "הססמא", "ססמא", "הססמא"]):
        return "הקוד לדלת הוא 1976"

    return "על איזה דלת מדובר?"


def GraffitiInText(user_message):
    if any(x in user_message for x in
           ["חומה", "חומות", "גדר", "גדרות", "בחוץ", "מגרש", "במגרש", "מחוץ"]):
        return "אני מקווה שהם לא מפריעים מדי בשבילך,למרות שהם נמצאים בכל מקום חחחח"

    return "הכוונה על הגרפיטי בחוץ"


def LampInText(user_message):
    if any(x in user_message for x in
           ["מקרטע", "מהבהב", "מהבהבת", "מקרטעת", "בחוץ", "מחוץ", "מדרגות ", "המדרגות", "מגרש", "המגרש", "בניין"]):
        return "אומרים בוועד שזאת בעייה בחיווי חשמל,אני בטוח שיפתרו את זה בקרוב מאוד"

    if any(x in user_message for x in
           ["שירותים", "בשירותים", "מקלחת", "במקלחת", "לשירותים", "לדירה", "השירותים", "המקלחת"]):
        return BathroomLightInText(user_message)

    return "על איזה אור מדברים פה"


def BathroomLightInText(user_message):
    if any(x in user_message for x in
           ["דולק", "דולקים", "דלוקים", "עובד", "עובדים"]):
        return "אופס בשטעות שכחתי לכבות חחח"
    if any(x in user_message for x in
           ["נכבו", "כיבו", "כיבה", "הלכו", "נחשך", "נחשכו", "נכבה", "נכבתה"]):
        return "מוזר,אולי קרה משהוא בתיבת חשמל, ממליץ לך לבדוק אותו"

    return "לא הבנתי,מה בדיוק הבעיה בתאורה בשירותים"


def ClosetInText(user_message):
    if any(x in user_message for x in
           ["חשמל", "החשמל"]):
        return ElectricBoxInText(user_message)

    return "אין לי ארון בדירה..."


def ElectricBoxInText(user_message):
    if any(x in user_message for x in
           ["פיוז", "חסר","אין","נעלם"]):
        return "וואלה! יש מצב שיש לי אחד נוסף איפשהיא במטבח"
    if any(x in user_message for x in
           ["דביק", "דביקה"]):
        return "הוא קצת ישן,מקווה שלא מפריע לך יותר מידי -_-"

    return "מה העיה עם הארון חשמל"


def TVInText(user_message):
    if any(x in user_message for x in
           ["רועש", "רועשת"]):
        return "כן היא די ישנה, אי-אפשר לשנות את הווליום"

    if any(x in user_message for x in
           ["ישן", "ישנה","עתיק","עתיקה"]):
        return "כל עוד הוא עובד זה טוב בשבילי"

    if any(x in user_message for x in
           ["סטטי", "שלג","רעש"]):
        return "הטלוויזיה מחוברת רק לתקליטור,אלא אם שמים דיסק הוא יישאר סטטי"

    return "מה הבעיה כבר עם הטלוויזיה"


def DVDInText(user_message):
    if any(x in user_message for x in
           ["דיסק", "תקליט","קלטת","להכניס"]):
        return "אין דיסקים בדירה כרגע,אבל תמיד אפשר להביא (~:"

    return "מצאתי ליד השכונה,יוצא שהיא עדיין עובדת"


def PhoneInText(user_message):
    if any(x in user_message for x in
           ["עובד", "תקוע","אין","מענה"]):
        return "האמת שהוא לא באמת פועל, שמתי אותו ליופי,אני ממש אוהב רטרו"

    if any(x in user_message for x in
           ["קוד", "הקוד", "לקוד", "קוד", "הקוד", "לססמה", "ססמה", "הססמה", "סיסמה", "הסיסמה", "סיסמה", "הסיסמה"
               , "הססמא", "צופן", "צופן", "הצופן", "ססמא", "סיסמא", "סיסמא", "לסיסמא", "לסיסמא", "הסיסמא", "הסיסמא"
               , "הססמא", "ססמא", "הססמא"]):
        return "הכל חידות אצלך אה, מה כבר הצפייה שאגיד 5 בתוך 5?"

    return "אין כמו טלפונים ישנים של פעם"


def FridgeInText(user_message):
    if any(x in user_message for x in
           ["אדום", "אדומה","בורדו"]):
        return "שיתאים לצבע של המטבח עצמות,אדום זה גם צבע מאוד נועז"

    if any(x in user_message for x in
           ["מכוער", "ישן","מפחיד","מטונף","מגעיל","מסריח"]):
        return "ממש לא בא לי טוב היחס שלך"

    return "מה יש לדבר על המקרר"


def WashingInText(user_message):
    if any(x in user_message for x in
           ["מכוער", "ישן", "מפחיד", "מטונף", "מגעיל", "מסריח"]):
        return "אולי מכונת הכביסה קצת ישנה, אבל היא עדיין עושה את העבודה"

    return "יש מצב שהשארתי שם בגדים אחרי שטיפה"


def FuseInText(user_message):
    if any(x in user_message for x in
           ["איפה", "היכן","לאן"]):
        return "נראלי השארתי אותו ליד הכיור"

    return "אני תמיד מחזיק פיוס למקרים של בעיות חשמל"


def DrugsInText(user_message):
    if any(x in user_message for x in
           ["מטבח", "במטבח","המטבח"]):
        return "זה עוזר לי נגד כאבי ראש, במיוחד כאלו שאני מקבל משאלות חטטניות"

    if any(x in user_message for x in
           ["סלון", "בסלון","הסלון"]):
        return "אלו של חבר שלי,לא לגעת בהם בבקשה"

    return "לא צריך לדבר עליהם"


def BoxInText(user_message):
    if any(x in user_message for x in
           ["בפנים", "מכיל","מכילים","יש","בפנוכו","בבפנוכו","בתוך","פנים"]):
        return "בפנים יש את הדברים האישיים שלי שאני מפנה עבור החדר"

    if any(x in user_message for x in
           ["לאן", "איפה","היכן","באשר","איה"]):
        return "עוד לא חשבתי על זה, אני בטוח שאמצא להעביר את הדברים שלי"

    return "לא צריך להתייחס אליהם אני מתכוון להעביר אותם מהחדר"


def BedInText(user_message):
    if any(x in user_message for x in
           ["כתם", "הכתם","בכתם","לכתם","כתמים","הכתמים","לכתמים","בכתמים"]):
        return "אוי,להסתכל עליו בבקשה,אני אנקה אותו מאוד בקרוב :D"

    return "המיטה של חדר השינה...."


def MirrorInText(user_message):
    if any(x in user_message for x in
           ["כיתוב", "כתובת","כתוב","מרוח","מספרים","צופן","קוד","הקוד","הצופן","המספרים","הכיתוב","הכתובת","מצויר","חרוט","אדום","דם","בדם","שווה","שוויון","נכתב"]):
        return "אין לי מושג מאיפה הבאת את זה"

    return "זוהי סתם מראה ישנה שמצאתי ברחוב"


def CandleInText(user_message):
    if any(x in user_message for x in
           ["מדליק", "להדליק","מדליקה","גפרור","גפרורים","לגפרור","לגפרורים","מצית","מציתה","להצית","אש","","",""]):
        return "אשמח שלא יגעו בנר שלי,ובמיוחד שלא ידליקו אותו, תודה!"

    return "זה נר מאוד מיוחד בשבילי,קיבלתי אותו מתנה מאימי"




