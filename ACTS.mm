<map version="1.0.1">
<!-- To view this file, download free mind mapping software FreeMind from http://freemind.sourceforge.net -->
<node COLOR="#000000" CREATED="1759524439950" ID="ID_1259022798" MODIFIED="1759524538595" TEXT="Astronaut Career Tracking System (ACTS)">
<font NAME="SansSerif" SIZE="20"/>
<hook NAME="accessories/plugins/AutomaticLayout.properties"/>
<node COLOR="#0033ff" CREATED="1759524549914" ID="ID_1727969689" MODIFIED="1759524552088" POSITION="right" TEXT="API">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
</node>
<node COLOR="#0033ff" CREATED="1759524552320" ID="ID_1815815451" MODIFIED="1759524556249" POSITION="right" TEXT="UI">
<edge STYLE="sharp_bezier" WIDTH="8"/>
<font NAME="SansSerif" SIZE="18"/>
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
