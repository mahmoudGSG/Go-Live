var OxO5de4=["onload","onclick","btnCancel","btnOK","onkeyup","txtHSB_Hue","onkeypress","txtHSB_Saturation","txtHSB_Brightness","txtRGB_Red","txtRGB_Green","txtRGB_Blue","txtHex","btnWebSafeColor","rdoHSB_Hue","rdoHSB_Saturation","rdoHSB_Brightness","pnlGradient_Top","onmousemove","onmousedown","onmouseup","pnlVertical_Top","pnlWebSafeColor","pnlWebSafeColorBorder","pnlOldColor","lblHSB_Hue","lblHSB_Saturation","lblHSB_Brightness","length","\x5C{","\x5C}","BadNumber","A number between {0} and {1} is required. Closest value inserted.","Title","Color Picker","SelectAColor","Select a color:","OKButton","OK","CancelButton","Cancel","Recent","WebSafeWarning","Warning: not a web safe color","WebSafeClick","Click to select web safe color","HsbHue","H:","HsbHueTooltip","Hue","HsbHueUnit","%","HsbSaturation","S:","HsbSaturationTooltip","Saturation","HsbSaturationUnit","HsbBrightness","B:","HsbBrightnessTooltip","Brightness","HsbBrightnessUnit","RgbRed","R:","RgbRedTooltip","Red","RgbGreen","G:","RgbGreenTooltip","Green","RgbBlue","RgbBlueTooltip","Blue","Hex","#","RecentTooltip","Recent:","lblSelectColorMessage","lblRecent","lblRGB_Red","lblRGB_Green","lblRGB_Blue","lblHex","lblUnitHSB_Hue","lblUnitHSB_Saturation","lblUnitHSB_Brightness","pnlHSB_Hue","pnlHSB_Saturation","pnlHSB_Brightness","pnlRGB_Red","pnlRGB_Green","pnlRGB_Blue","frmColorPicker","Color","","FFFFFF","value","checked","ColorMode","ColorType","RecentColors","pnlRecent","border","style","0px","backgroundColor","target","rgb","(",")",",","display","none","title","innerHTML","backgroundPosition","px ","px","pnlGradientHsbHue_Hue","pnlGradientHsbHue_Black","pnlGradientHsbHue_White","pnlVerticalHsbHue_Background","pnlVerticalHsbSaturation_Hue","pnlVerticalHsbSaturation_White","pnlVerticalHsbBrightness_Hue","pnlVerticalHsbBrightness_Black","pnlVerticalRgb_Start","pnlVerticalRgb_End","pnlGradientRgb_Base","pnlGradientRgb_Invert","pnlGradientRgb_Overlay1","pnlGradientRgb_Overlay2","src","imgGradient","Load.ashx?type=image\x26file=cpns_ColorSpace1.png","Load.ashx?type=image\x26file=cpns_ColorSpace2.png","Load.ashx?type=image\x26file=cpns_Vertical1.png","#000000","Load.ashx?type=image\x26file=cpns_Vertical2.png","#ffffff","01234567879","which","abcdef","01234567879ABCDEF","opener","pnlGradientPosition","pnlNewColor","0123456789ABCDEFabcdef","000000","0","id","top","pnlVerticalPosition","backgroundImage","url(Load.ashx?type=image\x26file=cpns_GradientPositionDark.gif)","url(Load.ashx?type=image\x26file=cpns_GradientPositionLight.gif)","cancelBubble","pageX","pageY","className","GradientNormal","GradientFullScreen","_isverdown","=","; path=/;"," expires=",";","cookie","search","location","\x26","00336699CCFF","0x","do_select","frm","__cphex"];var POSITIONADJUSTX=22;var POSITIONADJUSTY=52;var POSITIONADJUSTZ=48;var ColorMode=1;var GradientPositionDark= new Boolean(false);var frm= new Object();var msg= new Object();var _xmlDocs= new Array();var _xmlIndex=-1;var _xml=null;LoadLanguage();window[OxO5de4[0]]=window_load;function initialize(){frm[OxO5de4[2]][OxO5de4[1]]=btnCancel_Click;frm[OxO5de4[3]][OxO5de4[1]]=btnOK_Click;frm[OxO5de4[5]][OxO5de4[4]]=Hsb_Changed;frm[OxO5de4[5]][OxO5de4[6]]=validateNumber;frm[OxO5de4[7]][OxO5de4[4]]=Hsb_Changed;frm[OxO5de4[7]][OxO5de4[6]]=validateNumber;frm[OxO5de4[8]][OxO5de4[4]]=Hsb_Changed;frm[OxO5de4[8]][OxO5de4[6]]=validateNumber;frm[OxO5de4[9]][OxO5de4[4]]=Rgb_Changed;frm[OxO5de4[9]][OxO5de4[6]]=validateNumber;frm[OxO5de4[10]][OxO5de4[4]]=Rgb_Changed;frm[OxO5de4[10]][OxO5de4[6]]=validateNumber;frm[OxO5de4[11]][OxO5de4[4]]=Rgb_Changed;frm[OxO5de4[11]][OxO5de4[6]]=validateNumber;frm[OxO5de4[12]][OxO5de4[4]]=Hex_Changed;frm[OxO5de4[12]][OxO5de4[6]]=validateHex;frm[OxO5de4[13]][OxO5de4[1]]=btnWebSafeColor_Click;frm[OxO5de4[14]][OxO5de4[1]]=rdoHsb_Hue_Click;frm[OxO5de4[15]][OxO5de4[1]]=rdoHsb_Saturation_Click;frm[OxO5de4[16]][OxO5de4[1]]=rdoHsb_Brightness_Click;document.getElementById(OxO5de4[17])[OxO5de4[1]]=pnlGradient_Top_Click;document.getElementById(OxO5de4[17])[OxO5de4[18]]=pnlGradient_Top_MouseMove;document.getElementById(OxO5de4[17])[OxO5de4[19]]=pnlGradient_Top_MouseDown;document.getElementById(OxO5de4[17])[OxO5de4[20]]=pnlGradient_Top_MouseUp;document.getElementById(OxO5de4[21])[OxO5de4[1]]=pnlVertical_Top_Click;document.getElementById(OxO5de4[21])[OxO5de4[18]]=pnlVertical_Top_MouseMove;document.getElementById(OxO5de4[21])[OxO5de4[19]]=pnlVertical_Top_MouseDown;document.getElementById(OxO5de4[21])[OxO5de4[20]]=pnlVertical_Top_MouseUp;document.getElementById(OxO5de4[22])[OxO5de4[1]]=btnWebSafeColor_Click;document.getElementById(OxO5de4[23])[OxO5de4[1]]=btnWebSafeColor_Click;document.getElementById(OxO5de4[24])[OxO5de4[1]]=pnlOldClick_Click;document.getElementById(OxO5de4[25])[OxO5de4[1]]=rdoHsb_Hue_Click;document.getElementById(OxO5de4[26])[OxO5de4[1]]=rdoHsb_Saturation_Click;document.getElementById(OxO5de4[27])[OxO5de4[1]]=rdoHsb_Brightness_Click;frm[OxO5de4[5]].focus();window.focus();} ;function formatString(Ox2aa){Ox2aa= new String(Ox2aa);for(var i=1;i<arguments[OxO5de4[28]];i++){Ox2aa=Ox2aa.replace( new RegExp(OxO5de4[29]+(i-1)+OxO5de4[30]),arguments[i]);} ;return Ox2aa;} ;function AddValue(Ox113,Ox4e){Ox4e= new String(Ox4e).toLowerCase();for(var i=0;i<Ox113[OxO5de4[28]];i++){if(Ox113[i]==Ox4e){return ;} ;} ;Ox113[Ox113[OxO5de4[28]]]=Ox4e;} ;function SniffLanguage(Ox11){} ;function LoadNextLanguage(){} ;function LoadLanguage(){msg[OxO5de4[31]]=OxO5de4[32];msg[OxO5de4[33]]=OxO5de4[34];msg[OxO5de4[35]]=OxO5de4[36];msg[OxO5de4[37]]=OxO5de4[38];msg[OxO5de4[39]]=OxO5de4[40];msg[OxO5de4[41]]=OxO5de4[41];msg[OxO5de4[42]]=OxO5de4[43];msg[OxO5de4[44]]=OxO5de4[45];msg[OxO5de4[46]]=OxO5de4[47];msg[OxO5de4[48]]=OxO5de4[49];msg[OxO5de4[50]]=OxO5de4[51];msg[OxO5de4[52]]=OxO5de4[53];msg[OxO5de4[54]]=OxO5de4[55];msg[OxO5de4[56]]=OxO5de4[51];msg[OxO5de4[57]]=OxO5de4[58];msg[OxO5de4[59]]=OxO5de4[60];msg[OxO5de4[61]]=OxO5de4[51];msg[OxO5de4[62]]=OxO5de4[63];msg[OxO5de4[64]]=OxO5de4[65];msg[OxO5de4[66]]=OxO5de4[67];msg[OxO5de4[68]]=OxO5de4[69];msg[OxO5de4[70]]=OxO5de4[58];msg[OxO5de4[71]]=OxO5de4[72];msg[OxO5de4[73]]=OxO5de4[74];msg[OxO5de4[75]]=OxO5de4[76];} ;function AssignLanguage(){} ;function localize(){SetHTML(document.getElementById(OxO5de4[77]),msg.SelectAColor,document.getElementById(OxO5de4[78]),msg.Recent,document.getElementById(OxO5de4[25]),msg.HsbHue,document.getElementById(OxO5de4[26]),msg.HsbSaturation,document.getElementById(OxO5de4[27]),msg.HsbBrightness,document.getElementById(OxO5de4[79]),msg.RgbRed,document.getElementById(OxO5de4[80]),msg.RgbGreen,document.getElementById(OxO5de4[81]),msg.RgbBlue,document.getElementById(OxO5de4[82]),msg.Hex,document.getElementById(OxO5de4[83]),msg.HsbHueUnit,document.getElementById(OxO5de4[84]),msg.HsbSaturationUnit,document.getElementById(OxO5de4[85]),msg.HsbBrightnessUnit);SetValue(frm.btnCancel,msg.CancelButton,frm.btnOK,msg.OKButton);SetTitle(frm.btnWebSafeColor,msg.WebSafeWarning,document.getElementById(OxO5de4[22]),msg.WebSafeClick,document.getElementById(OxO5de4[86]),msg.HsbHueTooltip,document.getElementById(OxO5de4[87]),msg.HsbSaturationTooltip,document.getElementById(OxO5de4[88]),msg.HsbBrightnessTooltip,document.getElementById(OxO5de4[89]),msg.RgbRedTooltip,document.getElementById(OxO5de4[90]),msg.RgbGreenTooltip,document.getElementById(OxO5de4[91]),msg.RgbBlueTooltip);} ;function window_load(Ox42){frm=document.getElementById(OxO5de4[92]);localize();initialize();var hex=GetQuery(OxO5de4[93]).toUpperCase();if(hex==OxO5de4[94]){hex=OxO5de4[95];} ;if(hex[OxO5de4[28]]==7){hex=hex.substr(1,6);} ;frm[OxO5de4[12]][OxO5de4[96]]=hex;Hex_Changed(Ox42);hex=Form_Get_Hex();SetBg(document.getElementById(OxO5de4[24]),hex);frm[OxO5de4[99]][ new Number(GetCookie(OxO5de4[98])||0)][OxO5de4[97]]=true;ColorMode_Changed(Ox42);var Ox2a0=GetCookie(OxO5de4[100])||OxO5de4[94];var Ox2b0=msg[OxO5de4[75]];for(var i=1;i<33;i++){if(Ox2a0[OxO5de4[28]]/6>=i){hex=Ox2a0.substr((i-1)*6,6);var Ox2b1=HexToRgb(hex);var title=formatString(msg.RecentTooltip,hex,Ox2b1[0],Ox2b1[1],Ox2b1[2]);SetBg(document.getElementById(OxO5de4[101]+i),hex);SetTitle(document.getElementById(OxO5de4[101]+i),title);document.getElementById(OxO5de4[101]+i)[OxO5de4[1]]=pnlRecent_Click;} else {document.getElementById(OxO5de4[101]+i)[OxO5de4[103]][OxO5de4[102]]=OxO5de4[104];} ;} ;} ;function pnlRecent_Click(Ox42){var Oxd5=Ox42[OxO5de4[106]][OxO5de4[103]][OxO5de4[105]];if(Oxd5.indexOf(OxO5de4[107])!=-1){var Ox2b1= new Array();Oxd5=Oxd5.substr(Oxd5.indexOf(OxO5de4[108])+1);Oxd5=Oxd5.substr(0,Oxd5.indexOf(OxO5de4[109]));Ox2b1[0]= new Number(Oxd5.substr(0,Oxd5.indexOf(OxO5de4[110])));Oxd5=Oxd5.substr(Oxd5.indexOf(OxO5de4[110])+1);Ox2b1[1]= new Number(Oxd5.substr(0,Oxd5.indexOf(OxO5de4[110])));Ox2b1[2]= new Number(Oxd5.substr(Oxd5.indexOf(OxO5de4[110])+1));Oxd5=RgbToHex(Ox2b1);} else {Oxd5=Oxd5.substr(1,6).toUpperCase();} ;frm[OxO5de4[12]][OxO5de4[96]]=Oxd5;Hex_Changed(Ox42);} ;function pnlOldClick_Click(Ox42){frm[OxO5de4[12]][OxO5de4[96]]=document.getElementById(OxO5de4[24])[OxO5de4[103]][OxO5de4[105]].substr(1,6).toUpperCase();Hex_Changed(Ox42);} ;function rdoHsb_Hue_Click(Ox42){frm[OxO5de4[14]][OxO5de4[97]]=true;ColorMode_Changed(Ox42);} ;function rdoHsb_Saturation_Click(Ox42){frm[OxO5de4[15]][OxO5de4[97]]=true;ColorMode_Changed(Ox42);} ;function rdoHsb_Brightness_Click(Ox42){frm[OxO5de4[16]][OxO5de4[97]]=true;ColorMode_Changed(Ox42);} ;function Hide(){for(var i=0;i<arguments[OxO5de4[28]];i++){if(arguments[i]){arguments[i][OxO5de4[103]][OxO5de4[111]]=OxO5de4[112];} ;} ;} ;function Show(){for(var i=0;i<arguments[OxO5de4[28]];i++){if(arguments[i]){arguments[i][OxO5de4[103]][OxO5de4[111]]=OxO5de4[94];} ;} ;} ;function SetValue(){for(var i=0;i<arguments[OxO5de4[28]];i+=2){arguments[i][OxO5de4[96]]=arguments[i+1];} ;} ;function SetTitle(){for(var i=0;i<arguments[OxO5de4[28]];i+=2){arguments[i][OxO5de4[113]]=arguments[i+1];} ;} ;function SetHTML(){for(var i=0;i<arguments[OxO5de4[28]];i+=2){arguments[i][OxO5de4[114]]=arguments[i+1];} ;} ;function SetBg(){for(var i=0;i<arguments[OxO5de4[28]];i+=2){if(arguments[i]){arguments[i][OxO5de4[103]][OxO5de4[105]]=OxO5de4[74]+arguments[i+1];} ;} ;} ;function SetBgPosition(){for(var i=0;i<arguments[OxO5de4[28]];i+=3){arguments[i][OxO5de4[103]][OxO5de4[115]]=arguments[i+1]+OxO5de4[116]+arguments[i+2]+OxO5de4[117];} ;} ;function ColorMode_Changed(Ox42){for(var i=0;i<3;i++){if(frm[OxO5de4[99]][i][OxO5de4[97]]){ColorMode=i;} ;} ;SetCookie(OxO5de4[98],ColorMode,60*60*24*365);Hide(document.getElementById(OxO5de4[118]),document.getElementById(OxO5de4[119]),document.getElementById(OxO5de4[120]),document.getElementById(OxO5de4[121]),document.getElementById(OxO5de4[122]),document.getElementById(OxO5de4[123]),document.getElementById(OxO5de4[124]),document.getElementById(OxO5de4[125]),document.getElementById(OxO5de4[126]),document.getElementById(OxO5de4[127]),document.getElementById(OxO5de4[128]),document.getElementById(OxO5de4[129]),document.getElementById(OxO5de4[130]),document.getElementById(OxO5de4[131]));switch(ColorMode){case 0:document.getElementById(OxO5de4[133])[OxO5de4[132]]=OxO5de4[134];Show(document.getElementById(OxO5de4[118]),document.getElementById(OxO5de4[119]),document.getElementById(OxO5de4[120]),document.getElementById(OxO5de4[121]));Hsb_Changed(Ox42);break ;;case 1:document.getElementById(OxO5de4[133])[OxO5de4[132]]=OxO5de4[135];document.getElementById(OxO5de4[122])[OxO5de4[132]]=OxO5de4[136];Show(document.getElementById(OxO5de4[118]),document.getElementById(OxO5de4[122]));document.getElementById(OxO5de4[118])[OxO5de4[103]][OxO5de4[105]]=OxO5de4[137];Hsb_Changed(Ox42);break ;;case 2:document.getElementById(OxO5de4[133])[OxO5de4[132]]=OxO5de4[135];document.getElementById(OxO5de4[122])[OxO5de4[132]]=OxO5de4[138];Show(document.getElementById(OxO5de4[118]),document.getElementById(OxO5de4[122]));document.getElementById(OxO5de4[118])[OxO5de4[103]][OxO5de4[105]]=OxO5de4[139];Hsb_Changed(Ox42);break ;;default:break ;;} ;} ;function btnWebSafeColor_Click(Ox42){var Ox2b1=HexToRgb(frm[OxO5de4[12]].value);Ox2b1=RgbToWebSafeRgb(Ox2b1);frm[OxO5de4[12]][OxO5de4[96]]=RgbToHex(Ox2b1);Hex_Changed(Ox42);} ;function checkWebSafe(){var Ox2b1=Form_Get_Rgb();if(RgbIsWebSafe(Ox2b1)){Hide(frm.btnWebSafeColor,document.getElementById(OxO5de4[22]),document.getElementById(OxO5de4[23]));} else {Ox2b1=RgbToWebSafeRgb(Ox2b1);SetBg(document.getElementById(OxO5de4[22]),RgbToHex(Ox2b1));Show(frm.btnWebSafeColor,document.getElementById(OxO5de4[22]),document.getElementById(OxO5de4[23]));} ;} ;function validateNumber(Ox42){var Ox2c6=String.fromCharCode(Ox42.which);if(IgnoreKey(Ox42)){return ;} ;if(OxO5de4[140].indexOf(Ox2c6)!=-1){return ;} ;Ox42[OxO5de4[141]]=0;} ;function validateHex(Ox42){if(IgnoreKey(Ox42)){return ;} ;var Ox2c6=String.fromCharCode(Ox42.which);if(OxO5de4[142].indexOf(Ox2c6)!=-1){return ;} ;if(OxO5de4[143].indexOf(Ox2c6)!=-1){return ;} ;} ;function IgnoreKey(Ox42){var Ox2c6=String.fromCharCode(Ox42.which);var Ox2c9= new Array(0,8,9,13,27);if(Ox2c6==null){return true;} ;for(var i=0;i<5;i++){if(Ox42[OxO5de4[141]]==Ox2c9[i]){return true;} ;} ;return false;} ;function btnCancel_Click(){if(window[OxO5de4[144]]){window[OxO5de4[144]].focus();} ;top.close();} ;function btnOK_Click(){var hex= new String(frm[OxO5de4[12]].value);if(window[OxO5de4[144]]){try{window[OxO5de4[144]].ColorPicker_Picked(hex);} catch(e){} ;window[OxO5de4[144]].focus();} ;recent=GetCookie(OxO5de4[100])||OxO5de4[94];for(var i=0;i<recent[OxO5de4[28]];i+=6){if(recent.substr(i,6)==hex){recent=recent.substr(0,i)+recent.substr(i+6);i-=6;} ;} ;if(recent[OxO5de4[28]]>31*6){recent=recent.substr(0,31*6);} ;recent=frm[OxO5de4[12]][OxO5de4[96]]+recent;SetCookie(OxO5de4[100],recent,60*60*24*365);top.close();} ;function SetGradientPosition(Ox42,x,y){x=x-POSITIONADJUSTX+5;y=y-POSITIONADJUSTY+5;x-=7;y-=27;x=x<0?0:x>255?255:x;y=y<0?0:y>255?255:y;SetBgPosition(document.getElementById(OxO5de4[145]),x-5,y-5);switch(ColorMode){case 0:var Ox2cd= new Array(0,0,0);Ox2cd[1]=x/255;Ox2cd[2]=1-(y/255);frm[OxO5de4[7]][OxO5de4[96]]=Math.round(Ox2cd[1]*100);frm[OxO5de4[8]][OxO5de4[96]]=Math.round(Ox2cd[2]*100);Hsb_Changed(Ox42);break ;;case 1:var Ox2cd= new Array(0,0,0);Ox2cd[0]=x/255;Ox2cd[2]=1-(y/255);frm[OxO5de4[5]][OxO5de4[96]]=Ox2cd[0]==1?0:Math.round(Ox2cd[0]*360);frm[OxO5de4[8]][OxO5de4[96]]=Math.round(Ox2cd[2]*100);Hsb_Changed(Ox42);break ;;case 2:var Ox2cd= new Array(0,0,0);Ox2cd[0]=x/255;Ox2cd[1]=1-(y/255);frm[OxO5de4[5]][OxO5de4[96]]=Ox2cd[0]==1?0:Math.round(Ox2cd[0]*360);frm[OxO5de4[7]][OxO5de4[96]]=Math.round(Ox2cd[1]*100);Hsb_Changed(Ox42);break ;;} ;} ;function Hex_Changed(Ox42){var hex=Form_Get_Hex();var Ox2b1=HexToRgb(hex);var Ox2cd=RgbToHsb(Ox2b1);Form_Set_Rgb(Ox2b1);Form_Set_Hsb(Ox2cd);SetBg(document.getElementById(OxO5de4[146]),hex);SetupCursors(Ox42);SetupGradients();checkWebSafe();} ;function Rgb_Changed(Ox42){var Ox2b1=Form_Get_Rgb();var Ox2cd=RgbToHsb(Ox2b1);var hex=RgbToHex(Ox2b1);Form_Set_Hsb(Ox2cd);Form_Set_Hex(hex);SetBg(document.getElementById(OxO5de4[146]),hex);SetupCursors(Ox42);SetupGradients();checkWebSafe();} ;function Hsb_Changed(Ox42){var Ox2cd=Form_Get_Hsb();var Ox2b1=HsbToRgb(Ox2cd);var hex=RgbToHex(Ox2b1);Form_Set_Rgb(Ox2b1);Form_Set_Hex(hex);SetBg(document.getElementById(OxO5de4[146]),hex);SetupCursors(Ox42);SetupGradients();checkWebSafe();} ;function Form_Set_Hex(hex){frm[OxO5de4[12]][OxO5de4[96]]=hex;} ;function Form_Get_Hex(){var hex= new String(frm[OxO5de4[12]].value);for(var i=0;i<hex[OxO5de4[28]];i++){if(OxO5de4[147].indexOf(hex.substr(i,1))==-1){hex=OxO5de4[148];frm[OxO5de4[12]][OxO5de4[96]]=hex;alert(formatString(msg.BadNumber,OxO5de4[148],OxO5de4[95]));break ;} ;} ;while(hex[OxO5de4[28]]<6){hex=OxO5de4[149]+hex;} ;return hex;} ;function Form_Get_Hsb(){var Ox2cd= new Array(0,0,0);Ox2cd[0]= new Number(frm[OxO5de4[5]].value)/360;Ox2cd[1]= new Number(frm[OxO5de4[7]].value)/100;Ox2cd[2]= new Number(frm[OxO5de4[8]].value)/100;if(Ox2cd[0]>1||isNaN(Ox2cd[0])){Ox2cd[0]=1;frm[OxO5de4[5]][OxO5de4[96]]=360;alert(formatString(msg.BadNumber,0,360));} ;if(Ox2cd[1]>1||isNaN(Ox2cd[1])){Ox2cd[1]=1;frm[OxO5de4[7]][OxO5de4[96]]=100;alert(formatString(msg.BadNumber,0,100));} ;if(Ox2cd[2]>1||isNaN(Ox2cd[2])){Ox2cd[2]=1;frm[OxO5de4[8]][OxO5de4[96]]=100;alert(formatString(msg.BadNumber,0,100));} ;return Ox2cd;} ;function Form_Set_Hsb(Ox2cd){SetValue(frm.txtHSB_Hue,Math.round(Ox2cd[0]*360),frm.txtHSB_Saturation,Math.round(Ox2cd[1]*100),frm.txtHSB_Brightness,Math.round(Ox2cd[2]*100));} ;function Form_Get_Rgb(){var Ox2b1= new Array(0,0,0);Ox2b1[0]= new Number(frm[OxO5de4[9]].value);Ox2b1[1]= new Number(frm[OxO5de4[10]].value);Ox2b1[2]= new Number(frm[OxO5de4[11]].value);if(Ox2b1[0]>255||isNaN(Ox2b1[0])||Ox2b1[0]!=Math.round(Ox2b1[0])){Ox2b1[0]=255;frm[OxO5de4[9]][OxO5de4[96]]=255;alert(formatString(msg.BadNumber,0,255));} ;if(Ox2b1[1]>255||isNaN(Ox2b1[1])||Ox2b1[1]!=Math.round(Ox2b1[1])){Ox2b1[1]=255;frm[OxO5de4[10]][OxO5de4[96]]=255;alert(formatString(msg.BadNumber,0,255));} ;if(Ox2b1[2]>255||isNaN(Ox2b1[2])||Ox2b1[2]!=Math.round(Ox2b1[2])){Ox2b1[2]=255;frm[OxO5de4[11]][OxO5de4[96]]=255;alert(formatString(msg.BadNumber,0,255));} ;return Ox2b1;} ;function Form_Set_Rgb(Ox2b1){frm[OxO5de4[9]][OxO5de4[96]]=Ox2b1[0];frm[OxO5de4[10]][OxO5de4[96]]=Ox2b1[1];frm[OxO5de4[11]][OxO5de4[96]]=Ox2b1[2];} ;function SetupCursors(Ox42){var Ox2cd=Form_Get_Hsb();var Ox2b1=Form_Get_Rgb();if(RgbToYuv(Ox2b1)[0]>=0.5){SetGradientPositionDark();} else {SetGradientPositionLight();} ;if(Ox42[OxO5de4[106]]!=null){if(Ox42[OxO5de4[106]][OxO5de4[150]]==OxO5de4[17]){return ;} ;if(Ox42[OxO5de4[106]][OxO5de4[150]]==OxO5de4[21]){return ;} ;} ;var x;var y;var z;if(ColorMode>=0&&ColorMode<=2){for(var i=0;i<3;i++){Ox2cd[i]*=255;} ;} ;switch(ColorMode){case 0:x=Ox2cd[1];y=Ox2cd[2];z=Ox2cd[0]==0?1:Ox2cd[0];break ;;case 1:x=Ox2cd[0]==0?1:Ox2cd[0];y=Ox2cd[2];z=Ox2cd[1];break ;;case 2:x=Ox2cd[0]==0?1:Ox2cd[0];y=Ox2cd[1];z=Ox2cd[2];break ;;} ;y=255-y;z=255-z;SetBgPosition(document.getElementById(OxO5de4[145]),x-5,y-5);document.getElementById(OxO5de4[152])[OxO5de4[103]][OxO5de4[151]]=(z+27)+OxO5de4[117];} ;function SetupGradients(){var Ox2cd=Form_Get_Hsb();var Ox2b1=Form_Get_Rgb();switch(ColorMode){case 0:SetBg(document.getElementById(OxO5de4[118]),RgbToHex(HueToRgb(Ox2cd[0])));break ;;case 1:SetBg(document.getElementById(OxO5de4[122]),RgbToHex(HsbToRgb( new Array(Ox2cd[0],1,Ox2cd[2]))));break ;;case 2:SetBg(document.getElementById(OxO5de4[122]),RgbToHex(HsbToRgb( new Array(Ox2cd[0],Ox2cd[1],1))));break ;;default:;} ;} ;function SetGradientPositionDark(){if(GradientPositionDark){return ;} ;GradientPositionDark=true;document.getElementById(OxO5de4[145])[OxO5de4[103]][OxO5de4[153]]=OxO5de4[154];} ;function SetGradientPositionLight(){if(!GradientPositionDark){return ;} ;GradientPositionDark=false;document.getElementById(OxO5de4[145])[OxO5de4[103]][OxO5de4[153]]=OxO5de4[155];} ;function pnlGradient_Top_Click(Ox42){Ox42[OxO5de4[156]]=true;SetGradientPosition(Ox42,Ox42[OxO5de4[157]]-5,Ox42[OxO5de4[158]]-5);document.getElementById(OxO5de4[17])[OxO5de4[159]]=OxO5de4[160];_down=false;} ;var _down=false;function pnlGradient_Top_MouseMove(Ox42){Ox42[OxO5de4[156]]=true;if(!_down){return ;} ;SetGradientPosition(Ox42,Ox42[OxO5de4[157]]-5,Ox42[OxO5de4[158]]-5);} ;function pnlGradient_Top_MouseDown(Ox42){Ox42[OxO5de4[156]]=true;_down=true;SetGradientPosition(Ox42,Ox42[OxO5de4[157]]-5,Ox42[OxO5de4[158]]-5);document.getElementById(OxO5de4[17])[OxO5de4[159]]=OxO5de4[161];} ;function pnlGradient_Top_MouseUp(Ox42){_down=false;Ox42[OxO5de4[156]]=true;SetGradientPosition(Ox42,Ox42[OxO5de4[157]]-5,Ox42[OxO5de4[158]]-5);document.getElementById(OxO5de4[17])[OxO5de4[159]]=OxO5de4[160];} ;function Document_MouseUp(){e[OxO5de4[156]]=true;document.getElementById(OxO5de4[17])[OxO5de4[159]]=OxO5de4[160];} ;function SetVerticalPosition(Ox42,z){var z=z-POSITIONADJUSTZ;if(z<27){z=27;} ;if(z>282){z=282;} ;document.getElementById(OxO5de4[152])[OxO5de4[103]][OxO5de4[151]]=z+OxO5de4[117];z=1-((z-27)/255);switch(ColorMode){case 0:if(z==1){z=0;} ;frm[OxO5de4[5]][OxO5de4[96]]=Math.round(z*360);Hsb_Changed(Ox42);break ;;case 1:frm[OxO5de4[7]][OxO5de4[96]]=Math.round(z*100);Hsb_Changed(Ox42);break ;;case 2:frm[OxO5de4[8]][OxO5de4[96]]=Math.round(z*100);Hsb_Changed(Ox42);break ;;} ;} ;function pnlVertical_Top_Click(Ox42){SetVerticalPosition(Ox42,Ox42[OxO5de4[158]]-5);Ox42[OxO5de4[156]]=true;} ;function pnlVertical_Top_MouseMove(Ox42){if(!window[OxO5de4[162]]){return ;} ;if(Ox42[OxO5de4[141]]!=1){return ;} ;SetVerticalPosition(Ox42,Ox42[OxO5de4[158]]-5);Ox42[OxO5de4[156]]=true;} ;function pnlVertical_Top_MouseDown(Ox42){window[OxO5de4[162]]=true;SetVerticalPosition(Ox42,Ox42[OxO5de4[158]]-5);Ox42[OxO5de4[156]]=true;} ;function pnlVertical_Top_MouseUp(Ox42){window[OxO5de4[162]]=false;SetVerticalPosition(Ox42,Ox42[OxO5de4[158]]-5);Ox42[OxO5de4[156]]=true;} ;function SetCookie(name,Ox4e,Ox4f){var Ox50=name+OxO5de4[163]+escape(Ox4e)+OxO5de4[164];if(Ox4f){var Ox51= new Date();Ox51.setSeconds(Ox51.getSeconds()+Ox4f);Ox50+=OxO5de4[165]+Ox51.toUTCString()+OxO5de4[166];} ;document[OxO5de4[167]]=Ox50;} ;function GetCookie(name){var Ox53=document[OxO5de4[167]].split(OxO5de4[166]);for(var i=0;i<Ox53[OxO5de4[28]];i++){var Ox54=Ox53[i].split(OxO5de4[163]);if(name==Ox54[0].replace(/\s/g,OxO5de4[94])){return unescape(Ox54[1]);} ;} ;} ;function GetCookieDictionary(){var Ox124={};var Ox53=document[OxO5de4[167]].split(OxO5de4[166]);for(var i=0;i<Ox53[OxO5de4[28]];i++){var Ox54=Ox53[i].split(OxO5de4[163]);Ox124[Ox54[0].replace(/\s/g,OxO5de4[94])]=unescape(Ox54[1]);} ;return Ox124;} ;function GetQuery(name){var i=0;while(window[OxO5de4[169]][OxO5de4[168]].indexOf(name+OxO5de4[163],i)!=-1){var Ox4e=window[OxO5de4[169]][OxO5de4[168]].substr(window[OxO5de4[169]][OxO5de4[168]].indexOf(name+OxO5de4[163],i));Ox4e=Ox4e.substr(name[OxO5de4[28]]+1);if(Ox4e.indexOf(OxO5de4[170])!=-1){if(Ox4e.indexOf(OxO5de4[170])==0){Ox4e=OxO5de4[94];} else {Ox4e=Ox4e.substr(0,Ox4e.indexOf(OxO5de4[170]));} ;} ;return unescape(Ox4e);} ;return OxO5de4[94];} ;function RgbIsWebSafe(Ox2b1){var hex=RgbToHex(Ox2b1);for(var i=0;i<3;i++){if(OxO5de4[171].indexOf(hex.substr(i*2,2))==-1){return false;} ;} ;return true;} ;function RgbToWebSafeRgb(Ox2b1){var Ox2e7= new Array(Ox2b1[0],Ox2b1[1],Ox2b1[2]);if(RgbIsWebSafe(Ox2b1)){return Ox2e7;} ;var Ox2e8= new Array(0x00,0x33,0x66,0x99,0xCC,0xFF);for(var i=0;i<3;i++){for(var j=1;j<6;j++){if(Ox2e7[i]>Ox2e8[j-1]&&Ox2e7[i]<Ox2e8[j]){if(Ox2e7[i]-Ox2e8[j-1]>Ox2e8[j]-Ox2e7[i]){Ox2e7[i]=Ox2e8[j];} else {Ox2e7[i]=Ox2e8[j-1];} ;break ;} ;} ;} ;return Ox2e7;} ;function RgbToYuv(Ox2b1){var Ox2ea= new Array();Ox2ea[0]=(Ox2b1[0]*0.299+Ox2b1[1]*0.587+Ox2b1[2]*0.114)/255;Ox2ea[1]=(Ox2b1[0]*-0.169+Ox2b1[1]*-0.332+Ox2b1[2]*0.500+128)/255;Ox2ea[2]=(Ox2b1[0]*0.500+Ox2b1[1]*-0.419+Ox2b1[2]*-0.0813+128)/255;return Ox2ea;} ;function RgbToHsb(Ox2b1){var Ox2ec= new Array(Ox2b1[0],Ox2b1[1],Ox2b1[2]);var Ox2ed= new Number(1);var Ox2ee= new Number(0);var Ox2ef= new Number(1);var Ox2cd= new Array(0,0,0);var Ox2f0= new Array();for(var i=0;i<3;i++){Ox2ec[i]=Ox2b1[i]/255;if(Ox2ec[i]<Ox2ed){Ox2ed=Ox2ec[i];} ;if(Ox2ec[i]>Ox2ee){Ox2ee=Ox2ec[i];} ;} ;Ox2ef=Ox2ee-Ox2ed;Ox2cd[2]=Ox2ee;if(Ox2ef==0){return Ox2cd;} ;Ox2cd[1]=Ox2ef/Ox2ee;for(var i=0;i<3;i++){Ox2f0[i]=(((Ox2ee-Ox2ec[i])/6)+(Ox2ef/2))/Ox2ef;} ;if(Ox2ec[0]==Ox2ee){Ox2cd[0]=Ox2f0[2]-Ox2f0[1];} else {if(Ox2ec[1]==Ox2ee){Ox2cd[0]=(1/3)+Ox2f0[0]-Ox2f0[2];} else {if(Ox2ec[2]==Ox2ee){Ox2cd[0]=(2/3)+Ox2f0[1]-Ox2f0[0];} ;} ;} ;if(Ox2cd[0]<0){Ox2cd[0]+=1;} else {if(Ox2cd[0]>1){Ox2cd[0]-=1;} ;} ;return Ox2cd;} ;function HsbToRgb(Ox2cd){var Ox2b1=HueToRgb(Ox2cd[0]);var Ox119=Ox2cd[2]*255;for(var i=0;i<3;i++){Ox2b1[i]=Ox2b1[i]*Ox2cd[2];Ox2b1[i]=((Ox2b1[i]-Ox119)*Ox2cd[1])+Ox119;Ox2b1[i]=Math.round(Ox2b1[i]);} ;return Ox2b1;} ;function RgbToHex(Ox2b1){var hex= new String();for(var i=0;i<3;i++){Ox2b1[2-i]=Math.round(Ox2b1[2-i]);hex=Ox2b1[2-i].toString(16)+hex;if(hex[OxO5de4[28]]%2==1){hex=OxO5de4[149]+hex;} ;} ;return hex.toUpperCase();} ;function HexToRgb(hex){var Ox2b1= new Array();for(var i=0;i<3;i++){Ox2b1[i]= new Number(OxO5de4[172]+hex.substr(i*2,2));} ;return Ox2b1;} ;function HueToRgb(Ox2f5){var Ox2f6=Ox2f5*360;var Ox2b1= new Array(0,0,0);var Ox2f7=(Ox2f6%60)/60;if(Ox2f6<60){Ox2b1[0]=255;Ox2b1[1]=Ox2f7*255;} else {if(Ox2f6<120){Ox2b1[1]=255;Ox2b1[0]=(1-Ox2f7)*255;} else {if(Ox2f6<180){Ox2b1[1]=255;Ox2b1[2]=Ox2f7*255;} else {if(Ox2f6<240){Ox2b1[2]=255;Ox2b1[1]=(1-Ox2f7)*255;} else {if(Ox2f6<300){Ox2b1[2]=255;Ox2b1[0]=Ox2f7*255;} else {if(Ox2f6<360){Ox2b1[0]=255;Ox2b1[2]=(1-Ox2f7)*255;} ;} ;} ;} ;} ;} ;return Ox2b1;} ;function CheckHexSelect(){if(window[OxO5de4[173]]&&window[OxO5de4[174]]&&frm[OxO5de4[12]]){var Oxd5=OxO5de4[74]+frm[OxO5de4[12]][OxO5de4[96]];if(Oxd5[OxO5de4[28]]==7){if(window[OxO5de4[175]]!=Oxd5){window[OxO5de4[175]]=Oxd5;window.do_select(Oxd5);} ;} ;} ;} ;setInterval(CheckHexSelect,10);