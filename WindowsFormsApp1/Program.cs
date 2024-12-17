using System;                         // 기본적인 시스템 기능을 위한 네임스페이스
using System.Collections.Generic;     // 제네릭 컬렉션 사용을 위한 네임스페이스
using System.Linq;                    // LINQ (Language Integrated Query)를 지원하는 네임스페이스
using System.Threading.Tasks;         // 비동기 프로그래밍과 작업 관리를 위한 네임스페이스
using System.Windows.Forms;           // Windows Forms 관련 클래스와 UI 요소를 제공하는 네임스페이스

namespace WindowsFormsApp1            // 프로젝트의 고유 네임스페이스
{
    static class Program              // 진입점(Main 메서드)을 포함하는 클래스
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]                   // COM 기반 멀티스레드 설정. Windows Forms 앱에서는 필수입니다.
        static void Main()            // 프로그램의 진입점 (메인 메서드)
        {
            // 애플리케이션에서 Windows의 시각적 스타일을 사용하도록 설정
            Application.EnableVisualStyles();

            // 애플리케이션의 텍스트 렌더링을 기본 설정에 맞추도록 설정
            Application.SetCompatibleTextRenderingDefault(false);

            // Form1 클래스를 시작 폼으로 실행
            Application.Run(new Form1());

            // Form1이 실행된 후, 메시지 박스를 띄움
            //MessageBox.Show("안녕하세요?"); // "안녕하세요?" 메시지를 표시하는 팝업 창

            

        }
    }

}
