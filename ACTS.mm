<map version="1.0.1">
<!-- To view this file, download free mind mapping software FreeMind from http://freemind.sourceforge.net -->
<node COLOR="#000000" CREATED="1759524439950" ID="ID_1259022798" MODIFIED="1759524538595" TEXT="Astronaut Career Tracking System (ACTS)">
<font NAME="SansSerif" SIZE="20"/>
<hook NAME="accessories/plugins/AutomaticLayout.properties"/>
<node COLOR="#0033ff" CREATED="1759524549914" ID="ID_1727969689" MODIFIED="1759735217166" POSITION="right" TEXT="API">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
<node COLOR="#00b439" CREATED="1759735217149" ID="ID_448108511" MODIFIED="1759735236262" TEXT="scalability">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1759733372645" ID="ID_866055239" MODIFIED="1759735217157" TEXT="have a command queue">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759733402563" ID="ID_1809609169" MODIFIED="1759735241912" TEXT="make command factory to use when pulling off command queue">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
<node COLOR="#00b439" CREATED="1759733441136" ID="ID_1781062845" MODIFIED="1759733480907" TEXT="add verification to api inputs for data safety">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
</node>
</node>
<node COLOR="#0033ff" CREATED="1759524552320" HGAP="12" ID="ID_1815815451" MODIFIED="1759735472538" POSITION="right" TEXT="UI" VSHIFT="79">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
<node COLOR="#00b439" CREATED="1759733489231" ID="ID_1430296278" MODIFIED="1759733536250" TEXT="timeline screen ">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1759733536252" ID="ID_814000803" MODIFIED="1759733540110" TEXT="would have the timeline component">
<font NAME="SansSerif" SIZE="14"/>
<node COLOR="#111111" CREATED="1759733568824" ID="ID_701368164" MODIFIED="1759733702853" TEXT="scrollable window for 25 years?"/>
<node COLOR="#111111" CREATED="1759733711094" ID="ID_854419552" MODIFIED="1759733783498" TEXT="fade new astronauts in (alphabetic)"/>
<node COLOR="#111111" CREATED="1759734988935" ID="ID_995928137" MODIFIED="1759735005286" TEXT="loading indicator while async request is running">
<node COLOR="#111111" CREATED="1759735066319" ID="ID_1231661045" MODIFIED="1759735192664">
<richcontent TYPE="NODE"><html>
  <head>
    
  </head>
  <body>
    <p>
      get request puts command on queue (async)
    </p>
    <p>
      then&#160;with the return url (for checking status of command in queue) awaits result
    </p>
  </body>
</html>
</richcontent>
</node>
</node>
</node>
<node COLOR="#990000" CREATED="1759733542103" ID="ID_917296691" MODIFIED="1759733565887" TEXT="have a paginated data table">
<font NAME="SansSerif" SIZE="14"/>
<node COLOR="#111111" CREATED="1759733804700" ID="ID_1556172882" MODIFIED="1759733836569" TEXT="Name, start date, rank, ???"/>
<node COLOR="#111111" CREATED="1759735014300" ID="ID_1239028342" MODIFIED="1759735020991" TEXT="loading indicator"/>
</node>
<node COLOR="#990000" CREATED="1759734944252" ID="ID_1105811058" MODIFIED="1759734959544" TEXT="add astronaut record button">
<font NAME="SansSerif" SIZE="14"/>
<node COLOR="#111111" CREATED="1759735325416" ID="ID_560026148" MODIFIED="1759735343215" TEXT="add modal">
<node COLOR="#111111" CREATED="1759735343217" ID="ID_1792275777" MODIFIED="1759735361499" TEXT="person drop-down"/>
<node COLOR="#111111" CREATED="1759735361964" ID="ID_966109978" MODIFIED="1759735367640" TEXT="rank"/>
<node COLOR="#111111" CREATED="1759735368531" ID="ID_165351606" MODIFIED="1759735377300" TEXT="start date"/>
<node COLOR="#111111" CREATED="1759735377769" ID="ID_1949129555" MODIFIED="1759735388658" TEXT="end date (nullable)"/>
</node>
</node>
</node>
<node COLOR="#00b439" CREATED="1759734907282" ID="ID_1350140272" MODIFIED="1759734914913" TEXT="person screen">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1759734915203" ID="ID_1972274881" MODIFIED="1759734965168" TEXT="add person button">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="14"/>
<node COLOR="#111111" CREATED="1759735325416" ID="ID_885273019" MODIFIED="1759735343215" TEXT="add modal">
<node COLOR="#111111" CREATED="1759735343217" ID="ID_1106724038" MODIFIED="1759735441757" TEXT="name"/>
</node>
</node>
</node>
</node>
<node COLOR="#0033ff" CREATED="1759524546461" ID="ID_121822832" MODIFIED="1759524549678" POSITION="left" TEXT="Data">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
<node COLOR="#00b439" CREATED="1759524587094" ID="ID_1178441610" MODIFIED="1759524633912" TEXT="person">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1759525484043" ID="ID_61650114" MODIFIED="1759525490628" TEXT="id: UUID">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759525491224" ID="ID_1663262534" MODIFIED="1759525525557" TEXT="name: varchar(250)">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
<node COLOR="#00b439" CREATED="1759525586538" ID="ID_1261656457" MODIFIED="1759525612846" TEXT="astronaut_details">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
</node>
<node COLOR="#00b439" CREATED="1759524596488" ID="ID_1884611801" MODIFIED="1759525634342" TEXT="astronaut_duty">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1759524779741" ID="ID_222869077" MODIFIED="1759524958003" TEXT="id: UUID">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524840941" ID="ID_1404759961" MODIFIED="1759524952119" TEXT="person_id: UUID">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524783674" ID="ID_1640060437" MODIFIED="1759524943211" TEXT="rank: vachar(50)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524792759" ID="ID_641804706" MODIFIED="1759524928452" TEXT="duty_title: varchar(250)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524801751" ID="ID_262887383" MODIFIED="1759524983065" TEXT="duty_date_start: DateTime2">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524823102" ID="ID_759787982" MODIFIED="1759524992704" TEXT="duty_date_end: DateTime2">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
<node COLOR="#00b439" CREATED="1759524602212" ID="ID_761843612" MODIFIED="1759524623406" TEXT="activity_log">
<edge STYLE="bezier" WIDTH="thin"/>
<font NAME="SansSerif" SIZE="16"/>
<node COLOR="#990000" CREATED="1759524655317" ID="ID_929714451" MODIFIED="1759525002404" TEXT="id: UUID">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524659943" ID="ID_1112900137" MODIFIED="1759525010762" TEXT="activity_date: DateTime2">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524681301" ID="ID_405867428" MODIFIED="1759525022212" TEXT="activity_action: varchar(2000)">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759525054466" ID="ID_1817412829" MODIFIED="1759525149971" TEXT="activity_action_type_id: UUID">
<font NAME="SansSerif" SIZE="14"/>
</node>
<node COLOR="#990000" CREATED="1759524694635" ID="ID_832356818" MODIFIED="1759525121999" TEXT="activity_user_id: UUID ... (person?)">
<font NAME="SansSerif" SIZE="14"/>
</node>
</node>
</node>
</node>
</map>
