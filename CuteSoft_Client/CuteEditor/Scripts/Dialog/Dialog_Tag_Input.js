var OxO50ac=["inp_type","inp_name","inp_value","row_txt1","inp_Size","row_txt2","inp_MaxLength","row_img","inp_src","btnbrowse","row_img2","sel_Align","optNotSet","optLeft","optRight","optTexttop","optAbsMiddle","optBaseline","optAbsBottom","optBottom","optMiddle","optTop","inp_Border","row_img3","inp_width","inp_height","row_img4","inp_HSpace","inp_VSpace","row_img5","AlternateText","inp_id","row_txt3","inp_access","row_txt4","inp_index","row_chk","inp_checked","row_txt5","inp_Disabled","row_txt6","inp_Readonly","onclick","value","Name","name","id","src","type","checked","disabled","readOnly","tabIndex","","accessKey","size","maxLength","width","height","vspace","hspace","border","align","alt","text","display","style","none","password","hidden","radio","checkbox","submit","reset","button","image","className","class"];var inp_type=Window_GetElement(window,OxO50ac[0],true);var inp_name=Window_GetElement(window,OxO50ac[1],true);var inp_value=Window_GetElement(window,OxO50ac[2],true);var row_txt1=Window_GetElement(window,OxO50ac[3],true);var inp_Size=Window_GetElement(window,OxO50ac[4],true);var row_txt2=Window_GetElement(window,OxO50ac[5],true);var inp_MaxLength=Window_GetElement(window,OxO50ac[6],true);var row_img=Window_GetElement(window,OxO50ac[7],true);var inp_src=Window_GetElement(window,OxO50ac[8],true);var btnbrowse=Window_GetElement(window,OxO50ac[9],true);var row_img2=Window_GetElement(window,OxO50ac[10],true);var sel_Align=Window_GetElement(window,OxO50ac[11],true);var optNotSet=Window_GetElement(window,OxO50ac[12],true);var optLeft=Window_GetElement(window,OxO50ac[13],true);var optRight=Window_GetElement(window,OxO50ac[14],true);var optTexttop=Window_GetElement(window,OxO50ac[15],true);var optAbsMiddle=Window_GetElement(window,OxO50ac[16],true);var optBaseline=Window_GetElement(window,OxO50ac[17],true);var optAbsBottom=Window_GetElement(window,OxO50ac[18],true);var optBottom=Window_GetElement(window,OxO50ac[19],true);var optMiddle=Window_GetElement(window,OxO50ac[20],true);var optTop=Window_GetElement(window,OxO50ac[21],true);var inp_Border=Window_GetElement(window,OxO50ac[22],true);var row_img3=Window_GetElement(window,OxO50ac[23],true);var inp_width=Window_GetElement(window,OxO50ac[24],true);var inp_height=Window_GetElement(window,OxO50ac[25],true);var row_img4=Window_GetElement(window,OxO50ac[26],true);var inp_HSpace=Window_GetElement(window,OxO50ac[27],true);var inp_VSpace=Window_GetElement(window,OxO50ac[28],true);var row_img5=Window_GetElement(window,OxO50ac[29],true);var AlternateText=Window_GetElement(window,OxO50ac[30],true);var inp_id=Window_GetElement(window,OxO50ac[31],true);var row_txt3=Window_GetElement(window,OxO50ac[32],true);var inp_access=Window_GetElement(window,OxO50ac[33],true);var row_txt4=Window_GetElement(window,OxO50ac[34],true);var inp_index=Window_GetElement(window,OxO50ac[35],true);var row_chk=Window_GetElement(window,OxO50ac[36],true);var inp_checked=Window_GetElement(window,OxO50ac[37],true);var row_txt5=Window_GetElement(window,OxO50ac[38],true);var inp_Disabled=Window_GetElement(window,OxO50ac[39],true);var row_txt6=Window_GetElement(window,OxO50ac[40],true);var inp_Readonly=Window_GetElement(window,OxO50ac[41],true);btnbrowse[OxO50ac[42]]=function btnbrowse_onclick(){function Ox354(Ox137){if(Ox137){inp_src[OxO50ac[43]]=Ox137;SyncTo(element);} ;} ;editor.SetNextDialogWindow(window);if(Browser_IsSafari()){editor.ShowSelectImageDialog(Ox354,inp_src.value,inp_src);} else {editor.ShowSelectImageDialog(Ox354,inp_src.value);} ;} ;UpdateState=function UpdateState_Input(){} ;SyncToView=function SyncToView_Input(){if(element[OxO50ac[44]]){inp_name[OxO50ac[43]]=element[OxO50ac[44]];} ;if(element[OxO50ac[45]]){inp_name[OxO50ac[43]]=element[OxO50ac[45]];} ;inp_id[OxO50ac[43]]=element[OxO50ac[46]];inp_value[OxO50ac[43]]=(element[OxO50ac[43]]).trim();inp_src[OxO50ac[43]]=element[OxO50ac[47]];inp_type[OxO50ac[43]]=element[OxO50ac[48]];inp_checked[OxO50ac[49]]=element[OxO50ac[49]];inp_Disabled[OxO50ac[49]]=element[OxO50ac[50]];inp_Readonly[OxO50ac[49]]=element[OxO50ac[51]];if(element[OxO50ac[52]]==0){inp_index[OxO50ac[43]]=OxO50ac[53];} else {inp_index[OxO50ac[43]]=element[OxO50ac[52]];} ;if(element[OxO50ac[54]]){inp_access[OxO50ac[43]]=element[OxO50ac[54]];} ;if(element[OxO50ac[55]]){if(element[OxO50ac[55]]==20){inp_Size[OxO50ac[43]]=OxO50ac[53];} else {inp_Size[OxO50ac[43]]=element[OxO50ac[55]];} ;} ;if(element[OxO50ac[56]]){if(element[OxO50ac[56]]==2147483647||element[OxO50ac[56]]<=0){inp_MaxLength[OxO50ac[43]]=OxO50ac[53];} else {inp_MaxLength[OxO50ac[43]]=element[OxO50ac[56]];} ;} ;if(element[OxO50ac[57]]){inp_width[OxO50ac[43]]=element[OxO50ac[57]];} ;if(element[OxO50ac[58]]){inp_height[OxO50ac[43]]=element[OxO50ac[58]];} ;if(element[OxO50ac[59]]){inp_HSpace[OxO50ac[43]]=element[OxO50ac[59]];} ;if(element[OxO50ac[60]]){inp_VSpace[OxO50ac[43]]=element[OxO50ac[60]];} ;if(element[OxO50ac[61]]){inp_Border[OxO50ac[43]]=element[OxO50ac[61]];} ;if(element[OxO50ac[62]]){sel_Align[OxO50ac[43]]=element[OxO50ac[62]];} ;if(element[OxO50ac[63]]){alt[OxO50ac[43]]=element[OxO50ac[63]];} ;switch((element[OxO50ac[48]]).toLowerCase()){case OxO50ac[64]:;case OxO50ac[68]:row_img[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img3[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img4[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img5[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_chk[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];break ;;case OxO50ac[69]:row_img[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img3[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img4[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img5[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_chk[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt1[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt3[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt4[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt5[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt6[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];break ;;case OxO50ac[70]:;case OxO50ac[71]:row_img[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img3[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img4[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img5[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt1[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt6[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];break ;;case OxO50ac[72]:;case OxO50ac[73]:;case OxO50ac[74]:row_chk[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img3[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img4[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_img5[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt1[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt6[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];break ;;case OxO50ac[75]:row_chk[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt1[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt2[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];row_txt6[OxO50ac[66]][OxO50ac[65]]=OxO50ac[67];break ;;} ;} ;SyncTo=function SyncTo_Input(element){element[OxO50ac[45]]=inp_name[OxO50ac[43]];if(element[OxO50ac[44]]){element[OxO50ac[44]]=inp_name[OxO50ac[43]];} else {if(element[OxO50ac[45]]){element.removeAttribute(OxO50ac[45],0);element[OxO50ac[44]]=inp_name[OxO50ac[43]];} else {element[OxO50ac[44]]=inp_name[OxO50ac[43]];} ;} ;element[OxO50ac[46]]=inp_id[OxO50ac[43]];if(inp_src[OxO50ac[43]]){element[OxO50ac[47]]=inp_src[OxO50ac[43]];} ;element[OxO50ac[49]]=inp_checked[OxO50ac[49]];element[OxO50ac[43]]=inp_value[OxO50ac[43]];element.setAttribute(OxO50ac[43],inp_value.value);element[OxO50ac[50]]=inp_Disabled[OxO50ac[49]];element[OxO50ac[51]]=inp_Readonly[OxO50ac[49]];element[OxO50ac[54]]=inp_access[OxO50ac[43]];element[OxO50ac[52]]=inp_index[OxO50ac[43]];element[OxO50ac[56]]=inp_MaxLength[OxO50ac[43]];element[OxO50ac[57]]=inp_width[OxO50ac[43]];element[OxO50ac[58]]=inp_height[OxO50ac[43]];element[OxO50ac[59]]=inp_HSpace[OxO50ac[43]];element[OxO50ac[60]]=inp_VSpace[OxO50ac[43]];element[OxO50ac[61]]=inp_Border[OxO50ac[43]];element[OxO50ac[62]]=sel_Align[OxO50ac[43]];element[OxO50ac[63]]=AlternateText[OxO50ac[43]];try{element[OxO50ac[55]]=inp_Size[OxO50ac[43]];} catch(e){element[OxO50ac[55]]=20;} ;if(element[OxO50ac[52]]==OxO50ac[53]){element.removeAttribute(OxO50ac[52]);} ;if(element[OxO50ac[54]]==OxO50ac[53]){element.removeAttribute(OxO50ac[54]);} ;if(element[OxO50ac[56]]==OxO50ac[53]){element.removeAttribute(OxO50ac[56]);} ;if(element[OxO50ac[55]]==0){element.removeAttribute(OxO50ac[55]);} ;if(element[OxO50ac[57]]==0){element.removeAttribute(OxO50ac[57]);} ;if(element[OxO50ac[58]]==0){element.removeAttribute(OxO50ac[58]);} ;if(element[OxO50ac[60]]==OxO50ac[53]){element.removeAttribute(OxO50ac[60]);} ;if(element[OxO50ac[59]]==OxO50ac[53]){element.removeAttribute(OxO50ac[59]);} ;if(element[OxO50ac[46]]==OxO50ac[53]){element.removeAttribute(OxO50ac[46]);} ;if(element[OxO50ac[44]]==OxO50ac[53]){element.removeAttribute(OxO50ac[44]);} ;if(element[OxO50ac[63]]==OxO50ac[53]){element.removeAttribute(OxO50ac[63]);} ;if(element[OxO50ac[62]]==OxO50ac[53]){element.removeAttribute(OxO50ac[62]);} ;if(element[OxO50ac[76]]==OxO50ac[53]){element.removeAttribute(OxO50ac[77]);} ;if(element[OxO50ac[76]]==OxO50ac[53]){element.removeAttribute(OxO50ac[76]);} ;switch((element[OxO50ac[48]]).toLowerCase()){case OxO50ac[64]:;case OxO50ac[68]:;case OxO50ac[69]:;case OxO50ac[70]:;case OxO50ac[71]:;case OxO50ac[72]:;case OxO50ac[73]:;case OxO50ac[74]:element.removeAttribute(OxO50ac[58]);element.removeAttribute(OxO50ac[61]);element.removeAttribute(OxO50ac[47]);break ;;case OxO50ac[75]:break ;;} ;} ;