using System.Linq;
using System.Windows.Forms;

public class ListViewSorter : System.Collections.IComparer
{
    private int m_ByColumn;//העמודה שלפיה ממיינים
    public int ByColumn { get => m_ByColumn; set => m_ByColumn = value; }

    private SortOrder m_SortOrder;//הסדר שלפיו ממיינים

    public SortOrder SortOrder { get => m_SortOrder; set => m_SortOrder = value; }

    public int Compare(object listViewItem1, object listViewItem2)
    {
        //פעולת ההשוואה - תופעל עם הפעלת פעולת מיון על תיבת תצוגת הרשימה

        //מציאת הטקסט מתוך העמודה שלפיה המיון
        string text1 = (listViewItem1 as ListViewItem).SubItems[m_ByColumn].Text;
        string text2 = (listViewItem2 as ListViewItem).SubItems[m_ByColumn].Text;


        //החזרת ערך השוואה תואם - לפי השוואת מספרים
        //שימוש בפעולה מוכנה של מחרוזות לבדיקה האם כל התווים במחרוזת עונים לתנאי
        if (text1.All(char.IsDigit) && text1.All(char.IsDigit))
            if (m_SortOrder == SortOrder.Ascending)
                return int.Parse(text1).CompareTo(int.Parse(text2));
            else
                return int.Parse(text2).CompareTo(int.Parse(text1));

        //החזרת ערך השוואה תואם - לפי השוואת מחרוזות
        if (m_SortOrder == SortOrder.Ascending)
            return text1.CompareTo(text2);
        else
            return text2.CompareTo(text1);
    }
}