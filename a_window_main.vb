Public Class Form1
    Inherits System.Windows.Forms.Form
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents MainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
    Friend WithEvents ContextMenu1 As System.Windows.Forms.ContextMenu
    Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
    Friend WithEvents mainmenu_help_tentang As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
    Friend WithEvents AxWebBrowser1 As AxSHDocVw.AxWebBrowser
    Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
    Friend WithEvents mainmenu_help_online_tool_google_searchconsole As System.Windows.Forms.MenuItem
    Friend WithEvents mainmenu_help_online_tool_speech_texter As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem247 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem248 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem249 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem250 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem251 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem252 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem253 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem254 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem255 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem256 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem257 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem258 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem259 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem260 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem261 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem262 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem263 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem264 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem265 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem266 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem267 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem268 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem269 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem270 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem271 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem272 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem273 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem274 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem275 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem276 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem277 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem278 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem279 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem280 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem281 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem282 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem283 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem284 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem285 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem286 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem287 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem288 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem289 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem290 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem291 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem292 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem293 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem294 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem295 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem296 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem297 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem298 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem299 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem300 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem301 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem302 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem303 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem304 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem305 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem306 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem307 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem308 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem309 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem310 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem311 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem312 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem313 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem314 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem315 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem316 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem317 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem318 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem319 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem320 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem321 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem322 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem323 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem324 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem325 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem326 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem327 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem328 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem329 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem330 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem331 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem332 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem333 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem334 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem335 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem336 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem337 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem338 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem339 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem340 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem341 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem342 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem343 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem344 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem345 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem346 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem347 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem348 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem349 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem350 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem351 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem352 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem353 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem354 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem355 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem356 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem357 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem358 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem359 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem360 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem361 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem362 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem363 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem364 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem365 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem366 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem367 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem368 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem369 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem370 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem371 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem372 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem373 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem374 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem375 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem376 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem377 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem378 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem379 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem380 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem381 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem382 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem383 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem384 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem385 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem386 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem387 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem388 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem389 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem390 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem391 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem392 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem393 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem394 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem395 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem396 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem397 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem398 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem399 As System.Windows.Forms.MenuItem
    Friend WithEvents mainmenu_window_palette_database As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem400 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem401 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem402 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem403 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem404 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem405 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem406 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem407 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem408 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem409 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem410 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem411 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem412 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem413 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem414 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem415 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem416 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem417 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem418 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem419 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem420 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem421 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem422 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem423 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem424 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem425 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem426 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem427 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem428 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem429 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem430 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem431 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem432 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem433 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem434 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem435 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem436 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem437 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem438 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem439 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem440 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem441 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem442 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem443 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem444 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem445 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem446 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem447 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem448 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem449 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem450 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem451 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem452 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem453 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem454 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem455 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem456 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem457 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem458 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem459 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem460 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem461 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem462 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem463 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem464 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem465 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem466 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem467 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem468 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem469 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem470 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem471 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem472 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem473 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem474 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form1))
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem124 = New System.Windows.Forms.MenuItem
        Me.MenuItem125 = New System.Windows.Forms.MenuItem
        Me.MenuItem201 = New System.Windows.Forms.MenuItem
        Me.MenuItem202 = New System.Windows.Forms.MenuItem
        Me.MenuItem203 = New System.Windows.Forms.MenuItem
        Me.MenuItem204 = New System.Windows.Forms.MenuItem
        Me.MenuItem205 = New System.Windows.Forms.MenuItem
        Me.MenuItem206 = New System.Windows.Forms.MenuItem
        Me.MenuItem207 = New System.Windows.Forms.MenuItem
        Me.MenuItem396 = New System.Windows.Forms.MenuItem
        Me.MenuItem397 = New System.Windows.Forms.MenuItem
        Me.MenuItem393 = New System.Windows.Forms.MenuItem
        Me.MenuItem394 = New System.Windows.Forms.MenuItem
        Me.MenuItem395 = New System.Windows.Forms.MenuItem
        Me.MenuItem127 = New System.Windows.Forms.MenuItem
        Me.MenuItem196 = New System.Windows.Forms.MenuItem
        Me.MenuItem199 = New System.Windows.Forms.MenuItem
        Me.MenuItem198 = New System.Windows.Forms.MenuItem
        Me.MenuItem200 = New System.Windows.Forms.MenuItem
        Me.MenuItem386 = New System.Windows.Forms.MenuItem
        Me.MenuItem398 = New System.Windows.Forms.MenuItem
        Me.MenuItem387 = New System.Windows.Forms.MenuItem
        Me.MenuItem390 = New System.Windows.Forms.MenuItem
        Me.MenuItem389 = New System.Windows.Forms.MenuItem
        Me.MenuItem388 = New System.Windows.Forms.MenuItem
        Me.MenuItem391 = New System.Windows.Forms.MenuItem
        Me.MenuItem392 = New System.Windows.Forms.MenuItem
        Me.MenuItem197 = New System.Windows.Forms.MenuItem
        Me.MenuItem126 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem211 = New System.Windows.Forms.MenuItem
        Me.MenuItem288 = New System.Windows.Forms.MenuItem
        Me.MenuItem289 = New System.Windows.Forms.MenuItem
        Me.MenuItem290 = New System.Windows.Forms.MenuItem
        Me.MenuItem291 = New System.Windows.Forms.MenuItem
        Me.MenuItem292 = New System.Windows.Forms.MenuItem
        Me.MenuItem212 = New System.Windows.Forms.MenuItem
        Me.MenuItem213 = New System.Windows.Forms.MenuItem
        Me.MenuItem216 = New System.Windows.Forms.MenuItem
        Me.MenuItem188 = New System.Windows.Forms.MenuItem
        Me.MenuItem218 = New System.Windows.Forms.MenuItem
        Me.MenuItem293 = New System.Windows.Forms.MenuItem
        Me.MenuItem220 = New System.Windows.Forms.MenuItem
        Me.MenuItem217 = New System.Windows.Forms.MenuItem
        Me.MenuItem219 = New System.Windows.Forms.MenuItem
        Me.MenuItem221 = New System.Windows.Forms.MenuItem
        Me.MenuItem294 = New System.Windows.Forms.MenuItem
        Me.MenuItem295 = New System.Windows.Forms.MenuItem
        Me.MenuItem296 = New System.Windows.Forms.MenuItem
        Me.MenuItem214 = New System.Windows.Forms.MenuItem
        Me.MenuItem273 = New System.Windows.Forms.MenuItem
        Me.MenuItem276 = New System.Windows.Forms.MenuItem
        Me.MenuItem274 = New System.Windows.Forms.MenuItem
        Me.MenuItem275 = New System.Windows.Forms.MenuItem
        Me.MenuItem297 = New System.Windows.Forms.MenuItem
        Me.MenuItem298 = New System.Windows.Forms.MenuItem
        Me.MenuItem299 = New System.Windows.Forms.MenuItem
        Me.MenuItem215 = New System.Windows.Forms.MenuItem
        Me.MenuItem277 = New System.Windows.Forms.MenuItem
        Me.MenuItem279 = New System.Windows.Forms.MenuItem
        Me.MenuItem278 = New System.Windows.Forms.MenuItem
        Me.MenuItem280 = New System.Windows.Forms.MenuItem
        Me.MenuItem281 = New System.Windows.Forms.MenuItem
        Me.MenuItem282 = New System.Windows.Forms.MenuItem
        Me.MenuItem284 = New System.Windows.Forms.MenuItem
        Me.MenuItem283 = New System.Windows.Forms.MenuItem
        Me.MenuItem270 = New System.Windows.Forms.MenuItem
        Me.MenuItem271 = New System.Windows.Forms.MenuItem
        Me.MenuItem272 = New System.Windows.Forms.MenuItem
        Me.MenuItem285 = New System.Windows.Forms.MenuItem
        Me.MenuItem286 = New System.Windows.Forms.MenuItem
        Me.MenuItem287 = New System.Windows.Forms.MenuItem
        Me.MenuItem222 = New System.Windows.Forms.MenuItem
        Me.MenuItem427 = New System.Windows.Forms.MenuItem
        Me.MenuItem432 = New System.Windows.Forms.MenuItem
        Me.MenuItem431 = New System.Windows.Forms.MenuItem
        Me.MenuItem428 = New System.Windows.Forms.MenuItem
        Me.MenuItem430 = New System.Windows.Forms.MenuItem
        Me.MenuItem429 = New System.Windows.Forms.MenuItem
        Me.MenuItem415 = New System.Windows.Forms.MenuItem
        Me.MenuItem423 = New System.Windows.Forms.MenuItem
        Me.MenuItem424 = New System.Windows.Forms.MenuItem
        Me.MenuItem416 = New System.Windows.Forms.MenuItem
        Me.MenuItem417 = New System.Windows.Forms.MenuItem
        Me.MenuItem425 = New System.Windows.Forms.MenuItem
        Me.MenuItem421 = New System.Windows.Forms.MenuItem
        Me.MenuItem422 = New System.Windows.Forms.MenuItem
        Me.MenuItem418 = New System.Windows.Forms.MenuItem
        Me.MenuItem419 = New System.Windows.Forms.MenuItem
        Me.MenuItem420 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem137 = New System.Windows.Forms.MenuItem
        Me.MenuItem261 = New System.Windows.Forms.MenuItem
        Me.MenuItem262 = New System.Windows.Forms.MenuItem
        Me.MenuItem263 = New System.Windows.Forms.MenuItem
        Me.MenuItem264 = New System.Windows.Forms.MenuItem
        Me.MenuItem138 = New System.Windows.Forms.MenuItem
        Me.MenuItem413 = New System.Windows.Forms.MenuItem
        Me.MenuItem412 = New System.Windows.Forms.MenuItem
        Me.MenuItem414 = New System.Windows.Forms.MenuItem
        Me.MenuItem139 = New System.Windows.Forms.MenuItem
        Me.MenuItem265 = New System.Windows.Forms.MenuItem
        Me.MenuItem184 = New System.Windows.Forms.MenuItem
        Me.MenuItem183 = New System.Windows.Forms.MenuItem
        Me.MenuItem187 = New System.Windows.Forms.MenuItem
        Me.MenuItem185 = New System.Windows.Forms.MenuItem
        Me.MenuItem186 = New System.Windows.Forms.MenuItem
        Me.MenuItem266 = New System.Windows.Forms.MenuItem
        Me.MenuItem268 = New System.Windows.Forms.MenuItem
        Me.MenuItem267 = New System.Windows.Forms.MenuItem
        Me.MenuItem269 = New System.Windows.Forms.MenuItem
        Me.MenuItem193 = New System.Windows.Forms.MenuItem
        Me.MenuItem189 = New System.Windows.Forms.MenuItem
        Me.MenuItem190 = New System.Windows.Forms.MenuItem
        Me.MenuItem191 = New System.Windows.Forms.MenuItem
        Me.MenuItem192 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem195 = New System.Windows.Forms.MenuItem
        Me.MenuItem241 = New System.Windows.Forms.MenuItem
        Me.MenuItem242 = New System.Windows.Forms.MenuItem
        Me.MenuItem240 = New System.Windows.Forms.MenuItem
        Me.MenuItem239 = New System.Windows.Forms.MenuItem
        Me.MenuItem351 = New System.Windows.Forms.MenuItem
        Me.MenuItem353 = New System.Windows.Forms.MenuItem
        Me.MenuItem352 = New System.Windows.Forms.MenuItem
        Me.MenuItem366 = New System.Windows.Forms.MenuItem
        Me.MenuItem367 = New System.Windows.Forms.MenuItem
        Me.MenuItem368 = New System.Windows.Forms.MenuItem
        Me.MenuItem194 = New System.Windows.Forms.MenuItem
        Me.MenuItem168 = New System.Windows.Forms.MenuItem
        Me.MenuItem243 = New System.Windows.Forms.MenuItem
        Me.MenuItem244 = New System.Windows.Forms.MenuItem
        Me.MenuItem246 = New System.Windows.Forms.MenuItem
        Me.MenuItem245 = New System.Windows.Forms.MenuItem
        Me.MenuItem130 = New System.Windows.Forms.MenuItem
        Me.MenuItem247 = New System.Windows.Forms.MenuItem
        Me.MenuItem248 = New System.Windows.Forms.MenuItem
        Me.MenuItem249 = New System.Windows.Forms.MenuItem
        Me.MenuItem250 = New System.Windows.Forms.MenuItem
        Me.MenuItem251 = New System.Windows.Forms.MenuItem
        Me.MenuItem252 = New System.Windows.Forms.MenuItem
        Me.MenuItem253 = New System.Windows.Forms.MenuItem
        Me.MenuItem254 = New System.Windows.Forms.MenuItem
        Me.MenuItem255 = New System.Windows.Forms.MenuItem
        Me.MenuItem256 = New System.Windows.Forms.MenuItem
        Me.MenuItem131 = New System.Windows.Forms.MenuItem
        Me.MenuItem304 = New System.Windows.Forms.MenuItem
        Me.MenuItem406 = New System.Windows.Forms.MenuItem
        Me.MenuItem305 = New System.Windows.Forms.MenuItem
        Me.MenuItem306 = New System.Windows.Forms.MenuItem
        Me.MenuItem300 = New System.Windows.Forms.MenuItem
        Me.MenuItem301 = New System.Windows.Forms.MenuItem
        Me.MenuItem302 = New System.Windows.Forms.MenuItem
        Me.MenuItem303 = New System.Windows.Forms.MenuItem
        Me.MenuItem321 = New System.Windows.Forms.MenuItem
        Me.MenuItem322 = New System.Windows.Forms.MenuItem
        Me.MenuItem307 = New System.Windows.Forms.MenuItem
        Me.MenuItem308 = New System.Windows.Forms.MenuItem
        Me.MenuItem309 = New System.Windows.Forms.MenuItem
        Me.MenuItem310 = New System.Windows.Forms.MenuItem
        Me.MenuItem311 = New System.Windows.Forms.MenuItem
        Me.MenuItem312 = New System.Windows.Forms.MenuItem
        Me.MenuItem313 = New System.Windows.Forms.MenuItem
        Me.MenuItem314 = New System.Windows.Forms.MenuItem
        Me.MenuItem315 = New System.Windows.Forms.MenuItem
        Me.MenuItem407 = New System.Windows.Forms.MenuItem
        Me.MenuItem408 = New System.Windows.Forms.MenuItem
        Me.MenuItem409 = New System.Windows.Forms.MenuItem
        Me.MenuItem410 = New System.Windows.Forms.MenuItem
        Me.MenuItem411 = New System.Windows.Forms.MenuItem
        Me.MenuItem323 = New System.Windows.Forms.MenuItem
        Me.MenuItem324 = New System.Windows.Forms.MenuItem
        Me.MenuItem325 = New System.Windows.Forms.MenuItem
        Me.MenuItem132 = New System.Windows.Forms.MenuItem
        Me.MenuItem133 = New System.Windows.Forms.MenuItem
        Me.MenuItem316 = New System.Windows.Forms.MenuItem
        Me.MenuItem369 = New System.Windows.Forms.MenuItem
        Me.MenuItem317 = New System.Windows.Forms.MenuItem
        Me.MenuItem373 = New System.Windows.Forms.MenuItem
        Me.MenuItem371 = New System.Windows.Forms.MenuItem
        Me.MenuItem372 = New System.Windows.Forms.MenuItem
        Me.MenuItem370 = New System.Windows.Forms.MenuItem
        Me.MenuItem169 = New System.Windows.Forms.MenuItem
        Me.MenuItem328 = New System.Windows.Forms.MenuItem
        Me.MenuItem327 = New System.Windows.Forms.MenuItem
        Me.MenuItem326 = New System.Windows.Forms.MenuItem
        Me.MenuItem227 = New System.Windows.Forms.MenuItem
        Me.MenuItem229 = New System.Windows.Forms.MenuItem
        Me.MenuItem228 = New System.Windows.Forms.MenuItem
        Me.MenuItem230 = New System.Windows.Forms.MenuItem
        Me.MenuItem232 = New System.Windows.Forms.MenuItem
        Me.MenuItem231 = New System.Windows.Forms.MenuItem
        Me.MenuItem134 = New System.Windows.Forms.MenuItem
        Me.MenuItem233 = New System.Windows.Forms.MenuItem
        Me.MenuItem234 = New System.Windows.Forms.MenuItem
        Me.MenuItem235 = New System.Windows.Forms.MenuItem
        Me.MenuItem236 = New System.Windows.Forms.MenuItem
        Me.MenuItem237 = New System.Windows.Forms.MenuItem
        Me.MenuItem238 = New System.Windows.Forms.MenuItem
        Me.MenuItem335 = New System.Windows.Forms.MenuItem
        Me.MenuItem318 = New System.Windows.Forms.MenuItem
        Me.MenuItem319 = New System.Windows.Forms.MenuItem
        Me.MenuItem320 = New System.Windows.Forms.MenuItem
        Me.MenuItem336 = New System.Windows.Forms.MenuItem
        Me.MenuItem337 = New System.Windows.Forms.MenuItem
        Me.MenuItem338 = New System.Windows.Forms.MenuItem
        Me.MenuItem135 = New System.Windows.Forms.MenuItem
        Me.MenuItem136 = New System.Windows.Forms.MenuItem
        Me.MenuItem400 = New System.Windows.Forms.MenuItem
        Me.MenuItem403 = New System.Windows.Forms.MenuItem
        Me.MenuItem401 = New System.Windows.Forms.MenuItem
        Me.MenuItem402 = New System.Windows.Forms.MenuItem
        Me.MenuItem404 = New System.Windows.Forms.MenuItem
        Me.MenuItem448 = New System.Windows.Forms.MenuItem
        Me.MenuItem444 = New System.Windows.Forms.MenuItem
        Me.MenuItem446 = New System.Windows.Forms.MenuItem
        Me.MenuItem447 = New System.Windows.Forms.MenuItem
        Me.MenuItem449 = New System.Windows.Forms.MenuItem
        Me.MenuItem455 = New System.Windows.Forms.MenuItem
        Me.MenuItem456 = New System.Windows.Forms.MenuItem
        Me.MenuItem450 = New System.Windows.Forms.MenuItem
        Me.MenuItem451 = New System.Windows.Forms.MenuItem
        Me.MenuItem452 = New System.Windows.Forms.MenuItem
        Me.MenuItem453 = New System.Windows.Forms.MenuItem
        Me.MenuItem454 = New System.Windows.Forms.MenuItem
        Me.MenuItem445 = New System.Windows.Forms.MenuItem
        Me.MenuItem405 = New System.Windows.Forms.MenuItem
        Me.MenuItem443 = New System.Windows.Forms.MenuItem
        Me.MenuItem442 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem355 = New System.Windows.Forms.MenuItem
        Me.MenuItem356 = New System.Windows.Forms.MenuItem
        Me.MenuItem357 = New System.Windows.Forms.MenuItem
        Me.MenuItem354 = New System.Windows.Forms.MenuItem
        Me.MenuItem128 = New System.Windows.Forms.MenuItem
        Me.MenuItem129 = New System.Windows.Forms.MenuItem
        Me.MenuItem341 = New System.Windows.Forms.MenuItem
        Me.MenuItem342 = New System.Windows.Forms.MenuItem
        Me.MenuItem147 = New System.Windows.Forms.MenuItem
        Me.MenuItem148 = New System.Windows.Forms.MenuItem
        Me.MenuItem339 = New System.Windows.Forms.MenuItem
        Me.MenuItem340 = New System.Windows.Forms.MenuItem
        Me.MenuItem344 = New System.Windows.Forms.MenuItem
        Me.MenuItem345 = New System.Windows.Forms.MenuItem
        Me.MenuItem346 = New System.Windows.Forms.MenuItem
        Me.MenuItem347 = New System.Windows.Forms.MenuItem
        Me.MenuItem343 = New System.Windows.Forms.MenuItem
        Me.MenuItem348 = New System.Windows.Forms.MenuItem
        Me.MenuItem349 = New System.Windows.Forms.MenuItem
        Me.MenuItem350 = New System.Windows.Forms.MenuItem
        Me.MenuItem384 = New System.Windows.Forms.MenuItem
        Me.MenuItem385 = New System.Windows.Forms.MenuItem
        Me.MenuItem149 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem257 = New System.Windows.Forms.MenuItem
        Me.MenuItem383 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem170 = New System.Windows.Forms.MenuItem
        Me.MenuItem171 = New System.Windows.Forms.MenuItem
        Me.MenuItem172 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem258 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem154 = New System.Windows.Forms.MenuItem
        Me.MenuItem155 = New System.Windows.Forms.MenuItem
        Me.MenuItem156 = New System.Windows.Forms.MenuItem
        Me.MenuItem157 = New System.Windows.Forms.MenuItem
        Me.mainmenu_window_palette_database = New System.Windows.Forms.MenuItem
        Me.MenuItem159 = New System.Windows.Forms.MenuItem
        Me.MenuItem160 = New System.Windows.Forms.MenuItem
        Me.MenuItem161 = New System.Windows.Forms.MenuItem
        Me.MenuItem162 = New System.Windows.Forms.MenuItem
        Me.MenuItem163 = New System.Windows.Forms.MenuItem
        Me.MenuItem164 = New System.Windows.Forms.MenuItem
        Me.MenuItem166 = New System.Windows.Forms.MenuItem
        Me.MenuItem259 = New System.Windows.Forms.MenuItem
        Me.MenuItem260 = New System.Windows.Forms.MenuItem
        Me.MenuItem165 = New System.Windows.Forms.MenuItem
        Me.MenuItem167 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem360 = New System.Windows.Forms.MenuItem
        Me.MenuItem364 = New System.Windows.Forms.MenuItem
        Me.MenuItem365 = New System.Windows.Forms.MenuItem
        Me.MenuItem374 = New System.Windows.Forms.MenuItem
        Me.MenuItem375 = New System.Windows.Forms.MenuItem
        Me.MenuItem376 = New System.Windows.Forms.MenuItem
        Me.MenuItem362 = New System.Windows.Forms.MenuItem
        Me.MenuItem363 = New System.Windows.Forms.MenuItem
        Me.MenuItem377 = New System.Windows.Forms.MenuItem
        Me.MenuItem378 = New System.Windows.Forms.MenuItem
        Me.MenuItem379 = New System.Windows.Forms.MenuItem
        Me.MenuItem380 = New System.Windows.Forms.MenuItem
        Me.MenuItem382 = New System.Windows.Forms.MenuItem
        Me.MenuItem381 = New System.Windows.Forms.MenuItem
        Me.MenuItem361 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem104 = New System.Windows.Forms.MenuItem
        Me.MenuItem105 = New System.Windows.Forms.MenuItem
        Me.MenuItem106 = New System.Windows.Forms.MenuItem
        Me.MenuItem107 = New System.Windows.Forms.MenuItem
        Me.MenuItem108 = New System.Windows.Forms.MenuItem
        Me.MenuItem109 = New System.Windows.Forms.MenuItem
        Me.MenuItem110 = New System.Windows.Forms.MenuItem
        Me.MenuItem111 = New System.Windows.Forms.MenuItem
        Me.MenuItem112 = New System.Windows.Forms.MenuItem
        Me.MenuItem113 = New System.Windows.Forms.MenuItem
        Me.MenuItem114 = New System.Windows.Forms.MenuItem
        Me.MenuItem115 = New System.Windows.Forms.MenuItem
        Me.MenuItem116 = New System.Windows.Forms.MenuItem
        Me.MenuItem117 = New System.Windows.Forms.MenuItem
        Me.MenuItem119 = New System.Windows.Forms.MenuItem
        Me.MenuItem118 = New System.Windows.Forms.MenuItem
        Me.MenuItem120 = New System.Windows.Forms.MenuItem
        Me.MenuItem121 = New System.Windows.Forms.MenuItem
        Me.MenuItem122 = New System.Windows.Forms.MenuItem
        Me.MenuItem123 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem226 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem150 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.MenuItem153 = New System.Windows.Forms.MenuItem
        Me.MenuItem151 = New System.Windows.Forms.MenuItem
        Me.MenuItem224 = New System.Windows.Forms.MenuItem
        Me.MenuItem225 = New System.Windows.Forms.MenuItem
        Me.MenuItem223 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem177 = New System.Windows.Forms.MenuItem
        Me.MenuItem178 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem329 = New System.Windows.Forms.MenuItem
        Me.MenuItem330 = New System.Windows.Forms.MenuItem
        Me.MenuItem331 = New System.Windows.Forms.MenuItem
        Me.MenuItem332 = New System.Windows.Forms.MenuItem
        Me.MenuItem333 = New System.Windows.Forms.MenuItem
        Me.MenuItem334 = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.mainmenu_help_online_tool_google_searchconsole = New System.Windows.Forms.MenuItem
        Me.MenuItem173 = New System.Windows.Forms.MenuItem
        Me.mainmenu_help_online_tool_speech_texter = New System.Windows.Forms.MenuItem
        Me.MenuItem174 = New System.Windows.Forms.MenuItem
        Me.MenuItem175 = New System.Windows.Forms.MenuItem
        Me.MenuItem176 = New System.Windows.Forms.MenuItem
        Me.MenuItem181 = New System.Windows.Forms.MenuItem
        Me.MenuItem182 = New System.Windows.Forms.MenuItem
        Me.MenuItem140 = New System.Windows.Forms.MenuItem
        Me.MenuItem141 = New System.Windows.Forms.MenuItem
        Me.MenuItem399 = New System.Windows.Forms.MenuItem
        Me.MenuItem142 = New System.Windows.Forms.MenuItem
        Me.MenuItem143 = New System.Windows.Forms.MenuItem
        Me.MenuItem426 = New System.Windows.Forms.MenuItem
        Me.MenuItem145 = New System.Windows.Forms.MenuItem
        Me.MenuItem144 = New System.Windows.Forms.MenuItem
        Me.MenuItem146 = New System.Windows.Forms.MenuItem
        Me.MenuItem358 = New System.Windows.Forms.MenuItem
        Me.MenuItem359 = New System.Windows.Forms.MenuItem
        Me.MenuItem433 = New System.Windows.Forms.MenuItem
        Me.MenuItem434 = New System.Windows.Forms.MenuItem
        Me.MenuItem435 = New System.Windows.Forms.MenuItem
        Me.MenuItem437 = New System.Windows.Forms.MenuItem
        Me.MenuItem436 = New System.Windows.Forms.MenuItem
        Me.MenuItem438 = New System.Windows.Forms.MenuItem
        Me.MenuItem439 = New System.Windows.Forms.MenuItem
        Me.MenuItem440 = New System.Windows.Forms.MenuItem
        Me.MenuItem441 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem179 = New System.Windows.Forms.MenuItem
        Me.MenuItem158 = New System.Windows.Forms.MenuItem
        Me.MenuItem471 = New System.Windows.Forms.MenuItem
        Me.MenuItem180 = New System.Windows.Forms.MenuItem
        Me.MenuItem457 = New System.Windows.Forms.MenuItem
        Me.MenuItem458 = New System.Windows.Forms.MenuItem
        Me.MenuItem459 = New System.Windows.Forms.MenuItem
        Me.MenuItem460 = New System.Windows.Forms.MenuItem
        Me.MenuItem461 = New System.Windows.Forms.MenuItem
        Me.MenuItem462 = New System.Windows.Forms.MenuItem
        Me.MenuItem469 = New System.Windows.Forms.MenuItem
        Me.MenuItem463 = New System.Windows.Forms.MenuItem
        Me.MenuItem464 = New System.Windows.Forms.MenuItem
        Me.MenuItem465 = New System.Windows.Forms.MenuItem
        Me.MenuItem467 = New System.Windows.Forms.MenuItem
        Me.MenuItem466 = New System.Windows.Forms.MenuItem
        Me.MenuItem468 = New System.Windows.Forms.MenuItem
        Me.MenuItem470 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.mainmenu_help_tentang = New System.Windows.Forms.MenuItem
        Me.ContextMenu1 = New System.Windows.Forms.ContextMenu
        Me.AxWebBrowser1 = New AxSHDocVw.AxWebBrowser
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem208 = New System.Windows.Forms.MenuItem
        Me.MenuItem209 = New System.Windows.Forms.MenuItem
        Me.MenuItem210 = New System.Windows.Forms.MenuItem
        Me.MenuItem472 = New System.Windows.Forms.MenuItem
        Me.MenuItem473 = New System.Windows.Forms.MenuItem
        Me.MenuItem474 = New System.Windows.Forms.MenuItem
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem37, Me.MenuItem3, Me.MenuItem19, Me.MenuItem400, Me.MenuItem404, Me.MenuItem2, Me.MenuItem4, Me.MenuItem5, Me.MenuItem6})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem124, Me.MenuItem125, Me.MenuItem207, Me.MenuItem393, Me.MenuItem127, Me.MenuItem196, Me.MenuItem199, Me.MenuItem198, Me.MenuItem200, Me.MenuItem386, Me.MenuItem398, Me.MenuItem387, Me.MenuItem197, Me.MenuItem126})
        Me.MenuItem1.Text = "File"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 0
        Me.MenuItem124.Text = "New"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 1
        Me.MenuItem125.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem201, Me.MenuItem202, Me.MenuItem203, Me.MenuItem204})
        Me.MenuItem125.Text = "Open"
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 0
        Me.MenuItem201.Text = "Browse"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 1
        Me.MenuItem202.Text = "-"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 2
        Me.MenuItem203.Text = "Recent File"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 3
        Me.MenuItem204.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem205, Me.MenuItem206})
        Me.MenuItem204.Text = "Favorite File"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 0
        Me.MenuItem205.Text = "Open All"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 1
        Me.MenuItem206.Text = "-"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 2
        Me.MenuItem207.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem396, Me.MenuItem397})
        Me.MenuItem207.Text = "Open Bookmark"
        '
        'MenuItem396
        '
        Me.MenuItem396.Index = 0
        Me.MenuItem396.Text = "-"
        '
        'MenuItem397
        '
        Me.MenuItem397.Index = 1
        Me.MenuItem397.Text = "Add File to Bookmark"
        '
        'MenuItem393
        '
        Me.MenuItem393.Index = 3
        Me.MenuItem393.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem394, Me.MenuItem395})
        Me.MenuItem393.Text = "Open History File Version"
        '
        'MenuItem394
        '
        Me.MenuItem394.Index = 0
        Me.MenuItem394.Text = "-"
        '
        'MenuItem395
        '
        Me.MenuItem395.Index = 1
        Me.MenuItem395.Text = "Manage History"
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 4
        Me.MenuItem127.Text = "-"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 5
        Me.MenuItem196.Text = "From Recent Snippets"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 6
        Me.MenuItem199.Text = "From Recent Template"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 7
        Me.MenuItem198.Text = "From Recent Behavior Backend"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 8
        Me.MenuItem200.Text = "From Recent Behavior Frontend"
        '
        'MenuItem386
        '
        Me.MenuItem386.Index = 9
        Me.MenuItem386.Text = "-"
        '
        'MenuItem398
        '
        Me.MenuItem398.Index = 10
        Me.MenuItem398.Text = "Check Contribution"
        '
        'MenuItem387
        '
        Me.MenuItem387.Index = 11
        Me.MenuItem387.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem390, Me.MenuItem389, Me.MenuItem388, Me.MenuItem391, Me.MenuItem392})
        Me.MenuItem387.Text = "Upload"
        '
        'MenuItem390
        '
        Me.MenuItem390.Index = 0
        Me.MenuItem390.Text = "Github"
        '
        'MenuItem389
        '
        Me.MenuItem389.Index = 1
        Me.MenuItem389.Text = "Source Forge"
        '
        'MenuItem388
        '
        Me.MenuItem388.Index = 2
        Me.MenuItem388.Text = "Ftp"
        '
        'MenuItem391
        '
        Me.MenuItem391.Index = 3
        Me.MenuItem391.Text = "-"
        '
        'MenuItem392
        '
        Me.MenuItem392.Index = 4
        Me.MenuItem392.Text = "More Upload Tool"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 12
        Me.MenuItem197.Text = "-"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 13
        Me.MenuItem126.Text = "Exit"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 1
        Me.MenuItem37.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem211, Me.MenuItem212, Me.MenuItem213, Me.MenuItem214, Me.MenuItem215, Me.MenuItem270, Me.MenuItem222, Me.MenuItem427, Me.MenuItem415, Me.MenuItem416})
        Me.MenuItem37.Text = "Algoritma"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 0
        Me.MenuItem211.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem288, Me.MenuItem289, Me.MenuItem290, Me.MenuItem291, Me.MenuItem292})
        Me.MenuItem211.Text = "Master CRUD"
        '
        'MenuItem288
        '
        Me.MenuItem288.Index = 0
        Me.MenuItem288.Text = "Backend"
        '
        'MenuItem289
        '
        Me.MenuItem289.Index = 1
        Me.MenuItem289.Text = "Frontend"
        '
        'MenuItem290
        '
        Me.MenuItem290.Index = 2
        Me.MenuItem290.Text = "-"
        '
        'MenuItem291
        '
        Me.MenuItem291.Index = 3
        Me.MenuItem291.Text = "More Master CRUD"
        '
        'MenuItem292
        '
        Me.MenuItem292.Index = 4
        Me.MenuItem292.Text = "Add Master CRUD"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 1
        Me.MenuItem212.Text = "-"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 2
        Me.MenuItem213.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem216, Me.MenuItem188, Me.MenuItem218, Me.MenuItem293, Me.MenuItem220, Me.MenuItem217, Me.MenuItem219, Me.MenuItem221, Me.MenuItem294, Me.MenuItem295, Me.MenuItem296})
        Me.MenuItem213.Text = "Master"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 0
        Me.MenuItem216.Text = "Master Data Deskripsi"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 1
        Me.MenuItem188.Text = "Master Data Deskripsi + Detail"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 2
        Me.MenuItem218.Text = "Master Data Preview"
        '
        'MenuItem293
        '
        Me.MenuItem293.Index = 3
        Me.MenuItem293.Text = "Master Data Slideshow"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 4
        Me.MenuItem220.Text = "-"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 5
        Me.MenuItem217.Text = "Master Table Basic"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 6
        Me.MenuItem219.Text = "Master Table Recursive"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 7
        Me.MenuItem221.Text = "Master Table Recursive Filter Root"
        '
        'MenuItem294
        '
        Me.MenuItem294.Index = 8
        Me.MenuItem294.Text = "-"
        '
        'MenuItem295
        '
        Me.MenuItem295.Index = 9
        Me.MenuItem295.Text = "More Master Page"
        '
        'MenuItem296
        '
        Me.MenuItem296.Index = 10
        Me.MenuItem296.Text = "Add Master Page"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 3
        Me.MenuItem214.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem273, Me.MenuItem276, Me.MenuItem274, Me.MenuItem275, Me.MenuItem297, Me.MenuItem298, Me.MenuItem299})
        Me.MenuItem214.Text = "Insert"
        '
        'MenuItem273
        '
        Me.MenuItem273.Index = 0
        Me.MenuItem273.Text = "Recordset Dropdown"
        '
        'MenuItem276
        '
        Me.MenuItem276.Index = 1
        Me.MenuItem276.Text = "-"
        '
        'MenuItem274
        '
        Me.MenuItem274.Index = 2
        Me.MenuItem274.Text = "Form Insert Basic"
        '
        'MenuItem275
        '
        Me.MenuItem275.Index = 3
        Me.MenuItem275.Text = "Form Insert Multiple"
        '
        'MenuItem297
        '
        Me.MenuItem297.Index = 4
        Me.MenuItem297.Text = "-"
        '
        'MenuItem298
        '
        Me.MenuItem298.Index = 5
        Me.MenuItem298.Text = "More Form Insert"
        '
        'MenuItem299
        '
        Me.MenuItem299.Index = 6
        Me.MenuItem299.Text = "Add Form Insert"
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 4
        Me.MenuItem215.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem277, Me.MenuItem279, Me.MenuItem278, Me.MenuItem280, Me.MenuItem281, Me.MenuItem282, Me.MenuItem284, Me.MenuItem283})
        Me.MenuItem215.Text = "Update"
        '
        'MenuItem277
        '
        Me.MenuItem277.Index = 0
        Me.MenuItem277.Text = "Recordset Basic"
        '
        'MenuItem279
        '
        Me.MenuItem279.Index = 1
        Me.MenuItem279.Text = "Recordset Dropdown"
        '
        'MenuItem278
        '
        Me.MenuItem278.Index = 2
        Me.MenuItem278.Text = "-"
        '
        'MenuItem280
        '
        Me.MenuItem280.Index = 3
        Me.MenuItem280.Text = "Update Form Wizard"
        '
        'MenuItem281
        '
        Me.MenuItem281.Index = 4
        Me.MenuItem281.Text = "Update Form Wizard Multiple"
        '
        'MenuItem282
        '
        Me.MenuItem282.Index = 5
        Me.MenuItem282.Text = "-"
        '
        'MenuItem284
        '
        Me.MenuItem284.Index = 6
        Me.MenuItem284.Text = "More Update Form"
        '
        'MenuItem283
        '
        Me.MenuItem283.Index = 7
        Me.MenuItem283.Text = "Add Update Form"
        '
        'MenuItem270
        '
        Me.MenuItem270.Index = 5
        Me.MenuItem270.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem271, Me.MenuItem272, Me.MenuItem285, Me.MenuItem286, Me.MenuItem287})
        Me.MenuItem270.Text = "Delete"
        '
        'MenuItem271
        '
        Me.MenuItem271.Index = 0
        Me.MenuItem271.Text = "Simple"
        '
        'MenuItem272
        '
        Me.MenuItem272.Index = 1
        Me.MenuItem272.Text = "Recursive"
        '
        'MenuItem285
        '
        Me.MenuItem285.Index = 2
        Me.MenuItem285.Text = "-"
        '
        'MenuItem286
        '
        Me.MenuItem286.Index = 3
        Me.MenuItem286.Text = "More Delete"
        '
        'MenuItem287
        '
        Me.MenuItem287.Index = 4
        Me.MenuItem287.Text = "Add Delete"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 6
        Me.MenuItem222.Text = "-"
        '
        'MenuItem427
        '
        Me.MenuItem427.Index = 7
        Me.MenuItem427.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem432, Me.MenuItem431, Me.MenuItem428, Me.MenuItem430, Me.MenuItem429})
        Me.MenuItem427.Text = "Canvas"
        '
        'MenuItem432
        '
        Me.MenuItem432.Index = 0
        Me.MenuItem432.Text = "Draw 2D"
        '
        'MenuItem431
        '
        Me.MenuItem431.Index = 1
        Me.MenuItem431.Text = "Fabric JS"
        '
        'MenuItem428
        '
        Me.MenuItem428.Index = 2
        Me.MenuItem428.Text = "Method Draw"
        '
        'MenuItem430
        '
        Me.MenuItem430.Index = 3
        Me.MenuItem430.Text = "React Diagram"
        '
        'MenuItem429
        '
        Me.MenuItem429.Index = 4
        Me.MenuItem429.Text = "SVG Edit"
        '
        'MenuItem415
        '
        Me.MenuItem415.Index = 8
        Me.MenuItem415.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem423, Me.MenuItem424})
        Me.MenuItem415.Text = "Directory"
        '
        'MenuItem423
        '
        Me.MenuItem423.Index = 0
        Me.MenuItem423.Text = "Directory Tree"
        '
        'MenuItem424
        '
        Me.MenuItem424.Index = 1
        Me.MenuItem424.Text = "Directory Description"
        '
        'MenuItem416
        '
        Me.MenuItem416.Index = 9
        Me.MenuItem416.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem417, Me.MenuItem425, Me.MenuItem421, Me.MenuItem422, Me.MenuItem418, Me.MenuItem419, Me.MenuItem420})
        Me.MenuItem416.Text = "Source"
        '
        'MenuItem417
        '
        Me.MenuItem417.Index = 0
        Me.MenuItem417.Text = "Compare"
        '
        'MenuItem425
        '
        Me.MenuItem425.Index = 1
        Me.MenuItem425.Text = "DOM Editor"
        '
        'MenuItem421
        '
        Me.MenuItem421.Index = 2
        Me.MenuItem421.Text = "-"
        '
        'MenuItem422
        '
        Me.MenuItem422.Index = 3
        Me.MenuItem422.Text = "Code Generator Builder"
        '
        'MenuItem418
        '
        Me.MenuItem418.Index = 4
        Me.MenuItem418.Text = "-"
        '
        'MenuItem419
        '
        Me.MenuItem419.Index = 5
        Me.MenuItem419.Text = "More Source Manipulatin"
        '
        'MenuItem420
        '
        Me.MenuItem420.Index = 6
        Me.MenuItem420.Text = "add Source Manipulatin"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem137, Me.MenuItem138, Me.MenuItem139, Me.MenuItem265, Me.MenuItem269, Me.MenuItem192})
        Me.MenuItem3.Text = "Data"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 0
        Me.MenuItem137.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem261, Me.MenuItem262, Me.MenuItem263, Me.MenuItem264})
        Me.MenuItem137.Text = "Behavior Backend"
        '
        'MenuItem261
        '
        Me.MenuItem261.Index = 0
        Me.MenuItem261.Text = "Recordset (Query Master)"
        '
        'MenuItem262
        '
        Me.MenuItem262.Index = 1
        Me.MenuItem262.Text = "Recordset (Query Dropdown)"
        '
        'MenuItem263
        '
        Me.MenuItem263.Index = 2
        Me.MenuItem263.Text = "Recordset (Query Costume)"
        '
        'MenuItem264
        '
        Me.MenuItem264.Index = 3
        Me.MenuItem264.Text = "-"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 1
        Me.MenuItem138.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem413, Me.MenuItem412, Me.MenuItem414})
        Me.MenuItem138.Text = "Behavior Frontend"
        '
        'MenuItem413
        '
        Me.MenuItem413.Index = 0
        Me.MenuItem413.Text = "Accordions"
        '
        'MenuItem412
        '
        Me.MenuItem412.Index = 1
        Me.MenuItem412.Text = "Tabs"
        '
        'MenuItem414
        '
        Me.MenuItem414.Index = 2
        Me.MenuItem414.Text = "Treeview"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 2
        Me.MenuItem139.Text = "-"
        '
        'MenuItem265
        '
        Me.MenuItem265.Index = 3
        Me.MenuItem265.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem184, Me.MenuItem183, Me.MenuItem187, Me.MenuItem185, Me.MenuItem186, Me.MenuItem266, Me.MenuItem268, Me.MenuItem267})
        Me.MenuItem265.Text = "Database Tool"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 0
        Me.MenuItem184.Text = "Table Designer"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 1
        Me.MenuItem183.Text = "Table Relation"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 2
        Me.MenuItem187.Text = "Table Structure"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 3
        Me.MenuItem185.Text = "Table Trigger"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 4
        Me.MenuItem186.Text = "Table View"
        '
        'MenuItem266
        '
        Me.MenuItem266.Index = 5
        Me.MenuItem266.Text = "-"
        '
        'MenuItem268
        '
        Me.MenuItem268.Index = 6
        Me.MenuItem268.Text = "More Tool"
        '
        'MenuItem267
        '
        Me.MenuItem267.Index = 7
        Me.MenuItem267.Text = "Add Tool"
        '
        'MenuItem269
        '
        Me.MenuItem269.Index = 4
        Me.MenuItem269.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem193, Me.MenuItem189, Me.MenuItem190, Me.MenuItem191})
        Me.MenuItem269.Text = "Distribution Format"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 0
        Me.MenuItem193.Text = "CSV"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 1
        Me.MenuItem189.Text = "DOM"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 2
        Me.MenuItem190.Text = "JSON"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 3
        Me.MenuItem191.Text = "XML"
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 5
        Me.MenuItem192.Text = "-"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 3
        Me.MenuItem19.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem195, Me.MenuItem351, Me.MenuItem194, Me.MenuItem168, Me.MenuItem130, Me.MenuItem131, Me.MenuItem132, Me.MenuItem133, Me.MenuItem316, Me.MenuItem169, Me.MenuItem227, Me.MenuItem134, Me.MenuItem318, Me.MenuItem135, Me.MenuItem136})
        Me.MenuItem19.Text = "Insert"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 0
        Me.MenuItem195.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem241, Me.MenuItem242, Me.MenuItem240, Me.MenuItem239})
        Me.MenuItem195.Text = "Favorite"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 0
        Me.MenuItem241.Text = "print_r()"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 1
        Me.MenuItem242.Text = "Object.keys()"
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 2
        Me.MenuItem240.Text = "-"
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 3
        Me.MenuItem239.Text = "New Favorite"
        '
        'MenuItem351
        '
        Me.MenuItem351.Index = 1
        Me.MenuItem351.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem353, Me.MenuItem352, Me.MenuItem366, Me.MenuItem367, Me.MenuItem368})
        Me.MenuItem351.Text = "MagicJS"
        '
        'MenuItem353
        '
        Me.MenuItem353.Index = 0
        Me.MenuItem353.Text = "Accodion"
        '
        'MenuItem352
        '
        Me.MenuItem352.Index = 1
        Me.MenuItem352.Text = "Tabs"
        '
        'MenuItem366
        '
        Me.MenuItem366.Index = 2
        Me.MenuItem366.Text = "-"
        '
        'MenuItem367
        '
        Me.MenuItem367.Index = 3
        Me.MenuItem367.Text = "Manage Magic"
        '
        'MenuItem368
        '
        Me.MenuItem368.Index = 4
        Me.MenuItem368.Text = "Add Magic"
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 2
        Me.MenuItem194.Text = "-"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 3
        Me.MenuItem168.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem243, Me.MenuItem244, Me.MenuItem246, Me.MenuItem245})
        Me.MenuItem168.Text = "Bootstrap"
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 0
        Me.MenuItem243.Text = "Alert"
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 1
        Me.MenuItem244.Text = "-"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 2
        Me.MenuItem246.Text = "More Bootstrap"
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 3
        Me.MenuItem245.Text = "New Bootstrap"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 4
        Me.MenuItem130.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem247, Me.MenuItem248, Me.MenuItem249, Me.MenuItem251, Me.MenuItem254, Me.MenuItem255, Me.MenuItem256})
        Me.MenuItem130.Text = "Form"
        '
        'MenuItem247
        '
        Me.MenuItem247.Index = 0
        Me.MenuItem247.Text = "Form"
        '
        'MenuItem248
        '
        Me.MenuItem248.Index = 1
        Me.MenuItem248.Text = "-"
        '
        'MenuItem249
        '
        Me.MenuItem249.Index = 2
        Me.MenuItem249.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem250})
        Me.MenuItem249.Text = "Textbox"
        '
        'MenuItem250
        '
        Me.MenuItem250.Index = 0
        Me.MenuItem250.Text = "Password"
        '
        'MenuItem251
        '
        Me.MenuItem251.Index = 3
        Me.MenuItem251.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem252, Me.MenuItem253})
        Me.MenuItem251.Text = "Date"
        '
        'MenuItem252
        '
        Me.MenuItem252.Index = 0
        Me.MenuItem252.Text = "Date"
        '
        'MenuItem253
        '
        Me.MenuItem253.Index = 1
        Me.MenuItem253.Text = "Date Time"
        '
        'MenuItem254
        '
        Me.MenuItem254.Index = 4
        Me.MenuItem254.Text = "-"
        '
        'MenuItem255
        '
        Me.MenuItem255.Index = 5
        Me.MenuItem255.Text = "More Object"
        '
        'MenuItem256
        '
        Me.MenuItem256.Index = 6
        Me.MenuItem256.Text = "New Object"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 5
        Me.MenuItem131.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem304, Me.MenuItem300, Me.MenuItem307, Me.MenuItem309, Me.MenuItem407, Me.MenuItem408, Me.MenuItem323, Me.MenuItem324, Me.MenuItem325})
        Me.MenuItem131.Text = "JQuery"
        '
        'MenuItem304
        '
        Me.MenuItem304.Index = 0
        Me.MenuItem304.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem406, Me.MenuItem305, Me.MenuItem306})
        Me.MenuItem304.Text = "Accordion"
        '
        'MenuItem406
        '
        Me.MenuItem406.Index = 0
        Me.MenuItem406.Text = "dl"
        '
        'MenuItem305
        '
        Me.MenuItem305.Index = 1
        Me.MenuItem305.Text = "List"
        '
        'MenuItem306
        '
        Me.MenuItem306.Index = 2
        Me.MenuItem306.Text = "Div"
        '
        'MenuItem300
        '
        Me.MenuItem300.Index = 1
        Me.MenuItem300.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem301, Me.MenuItem302, Me.MenuItem303, Me.MenuItem321, Me.MenuItem322})
        Me.MenuItem300.Text = "Tabs"
        '
        'MenuItem301
        '
        Me.MenuItem301.Index = 0
        Me.MenuItem301.Text = "Tab Top"
        '
        'MenuItem302
        '
        Me.MenuItem302.Index = 1
        Me.MenuItem302.Text = "Tab Left"
        '
        'MenuItem303
        '
        Me.MenuItem303.Index = 2
        Me.MenuItem303.Text = "Tab Bottom"
        '
        'MenuItem321
        '
        Me.MenuItem321.Index = 3
        Me.MenuItem321.Text = "-"
        '
        'MenuItem322
        '
        Me.MenuItem322.Index = 4
        Me.MenuItem322.Text = "Tab Panel Control"
        '
        'MenuItem307
        '
        Me.MenuItem307.Index = 2
        Me.MenuItem307.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem308})
        Me.MenuItem307.Text = "Menu"
        '
        'MenuItem308
        '
        Me.MenuItem308.Index = 0
        Me.MenuItem308.Text = "Dropdown"
        '
        'MenuItem309
        '
        Me.MenuItem309.Index = 3
        Me.MenuItem309.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem310, Me.MenuItem311, Me.MenuItem312, Me.MenuItem313, Me.MenuItem314, Me.MenuItem315})
        Me.MenuItem309.Text = "Context"
        '
        'MenuItem310
        '
        Me.MenuItem310.Index = 0
        Me.MenuItem310.Text = "List Basic"
        '
        'MenuItem311
        '
        Me.MenuItem311.Index = 1
        Me.MenuItem311.Text = "List Recursive"
        '
        'MenuItem312
        '
        Me.MenuItem312.Index = 2
        Me.MenuItem312.Text = "-"
        '
        'MenuItem313
        '
        Me.MenuItem313.Index = 3
        Me.MenuItem313.Text = "Popup List Basic"
        '
        'MenuItem314
        '
        Me.MenuItem314.Index = 4
        Me.MenuItem314.Text = "Popup List Recursive"
        '
        'MenuItem315
        '
        Me.MenuItem315.Index = 5
        Me.MenuItem315.Text = "-"
        '
        'MenuItem407
        '
        Me.MenuItem407.Index = 4
        Me.MenuItem407.Text = "-"
        '
        'MenuItem408
        '
        Me.MenuItem408.Index = 5
        Me.MenuItem408.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem409, Me.MenuItem410, Me.MenuItem411})
        Me.MenuItem408.Text = "Slider"
        '
        'MenuItem409
        '
        Me.MenuItem409.Index = 0
        Me.MenuItem409.Text = "Table Column Slider"
        '
        'MenuItem410
        '
        Me.MenuItem410.Index = 1
        Me.MenuItem410.Text = "Table Carousel"
        '
        'MenuItem411
        '
        Me.MenuItem411.Index = 2
        Me.MenuItem411.Text = "Table Fixed Column"
        '
        'MenuItem323
        '
        Me.MenuItem323.Index = 6
        Me.MenuItem323.Text = "-"
        '
        'MenuItem324
        '
        Me.MenuItem324.Index = 7
        Me.MenuItem324.Text = "More jQuery"
        '
        'MenuItem325
        '
        Me.MenuItem325.Index = 8
        Me.MenuItem325.Text = "Add jQuery"
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 6
        Me.MenuItem132.Text = "Vue"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 7
        Me.MenuItem133.Text = "-"
        '
        'MenuItem316
        '
        Me.MenuItem316.Index = 8
        Me.MenuItem316.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem369, Me.MenuItem317, Me.MenuItem373, Me.MenuItem371, Me.MenuItem372, Me.MenuItem370})
        Me.MenuItem316.Text = "Codemirror"
        '
        'MenuItem369
        '
        Me.MenuItem369.Index = 0
        Me.MenuItem369.Text = "Mainmenu"
        '
        'MenuItem317
        '
        Me.MenuItem317.Index = 1
        Me.MenuItem317.Text = "Toolbar"
        '
        'MenuItem373
        '
        Me.MenuItem373.Index = 2
        Me.MenuItem373.Text = "-"
        '
        'MenuItem371
        '
        Me.MenuItem371.Index = 3
        Me.MenuItem371.Text = "Palette Database"
        '
        'MenuItem372
        '
        Me.MenuItem372.Index = 4
        Me.MenuItem372.Text = "Palette File"
        '
        'MenuItem370
        '
        Me.MenuItem370.Index = 5
        Me.MenuItem370.Text = "-"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 9
        Me.MenuItem169.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem328, Me.MenuItem327, Me.MenuItem326})
        Me.MenuItem169.Text = "GoJS"
        '
        'MenuItem328
        '
        Me.MenuItem328.Index = 0
        Me.MenuItem328.Text = "Toolbox"
        '
        'MenuItem327
        '
        Me.MenuItem327.Index = 1
        Me.MenuItem327.Text = "Canvas"
        '
        'MenuItem326
        '
        Me.MenuItem326.Index = 2
        Me.MenuItem326.Text = "More GoJS Diagram"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 10
        Me.MenuItem227.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem229, Me.MenuItem228, Me.MenuItem230, Me.MenuItem232, Me.MenuItem231})
        Me.MenuItem227.Text = "JSTree"
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 0
        Me.MenuItem229.Text = "Database Explore"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 1
        Me.MenuItem228.Text = "File Explore"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 2
        Me.MenuItem230.Text = "-"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 3
        Me.MenuItem232.Text = "More JSTree"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 4
        Me.MenuItem231.Text = "New JSTree"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 11
        Me.MenuItem134.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem233, Me.MenuItem234, Me.MenuItem235, Me.MenuItem236, Me.MenuItem237, Me.MenuItem238, Me.MenuItem335})
        Me.MenuItem134.Text = "MXGraph"
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 0
        Me.MenuItem233.Text = "BPM"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 1
        Me.MenuItem234.Text = "Database Designer"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 2
        Me.MenuItem235.Text = "Flowchart"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 3
        Me.MenuItem236.Text = "-"
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 4
        Me.MenuItem237.Text = "More Diagram"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 5
        Me.MenuItem238.Text = "New Diagram"
        '
        'MenuItem335
        '
        Me.MenuItem335.Index = 6
        Me.MenuItem335.Text = "New Object"
        '
        'MenuItem318
        '
        Me.MenuItem318.Index = 12
        Me.MenuItem318.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem319, Me.MenuItem320, Me.MenuItem336, Me.MenuItem337, Me.MenuItem338})
        Me.MenuItem318.Text = "TinyMCE"
        '
        'MenuItem319
        '
        Me.MenuItem319.Index = 0
        Me.MenuItem319.Text = "Menu"
        '
        'MenuItem320
        '
        Me.MenuItem320.Index = 1
        Me.MenuItem320.Text = "Toolbar"
        '
        'MenuItem336
        '
        Me.MenuItem336.Index = 2
        Me.MenuItem336.Text = "-"
        '
        'MenuItem337
        '
        Me.MenuItem337.Index = 3
        Me.MenuItem337.Text = "More Object"
        '
        'MenuItem338
        '
        Me.MenuItem338.Index = 4
        Me.MenuItem338.Text = "Add Object"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 13
        Me.MenuItem135.Text = "-"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 14
        Me.MenuItem136.Text = "New Object"
        '
        'MenuItem400
        '
        Me.MenuItem400.Index = 4
        Me.MenuItem400.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem403, Me.MenuItem401})
        Me.MenuItem400.Text = "Api"
        '
        'MenuItem403
        '
        Me.MenuItem403.Index = 0
        Me.MenuItem403.Text = "Facebook"
        '
        'MenuItem401
        '
        Me.MenuItem401.Index = 1
        Me.MenuItem401.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem402})
        Me.MenuItem401.Text = "Github"
        '
        'MenuItem402
        '
        Me.MenuItem402.Index = 0
        Me.MenuItem402.Text = "Textbox Search Repository"
        '
        'MenuItem404
        '
        Me.MenuItem404.Index = 5
        Me.MenuItem404.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem448, Me.MenuItem444, Me.MenuItem446, Me.MenuItem447, Me.MenuItem449, Me.MenuItem455, Me.MenuItem456, Me.MenuItem450, Me.MenuItem451, Me.MenuItem452, Me.MenuItem453, Me.MenuItem454, Me.MenuItem445, Me.MenuItem405, Me.MenuItem443, Me.MenuItem442})
        Me.MenuItem404.Text = "Ria"
        '
        'MenuItem448
        '
        Me.MenuItem448.Index = 0
        Me.MenuItem448.Text = "Dreamweaver PHP Data Object jQuery Bootstrap"
        '
        'MenuItem444
        '
        Me.MenuItem444.Index = 1
        Me.MenuItem444.Text = "Dreamweaver PHP MySQL jQuery Spry"
        '
        'MenuItem446
        '
        Me.MenuItem446.Index = 2
        Me.MenuItem446.Text = "Dreamweaver PHP MySQLi Procedural jQuery Bootstrap"
        '
        'MenuItem447
        '
        Me.MenuItem447.Index = 3
        Me.MenuItem447.Text = "Dreamweaver PHP MySQLi Object jQuery Bootstrap"
        '
        'MenuItem449
        '
        Me.MenuItem449.Index = 4
        Me.MenuItem449.Text = "-"
        '
        'MenuItem455
        '
        Me.MenuItem455.Index = 5
        Me.MenuItem455.Text = "Senimandigital PHP Data Object jQuery Bootstrap"
        '
        'MenuItem456
        '
        Me.MenuItem456.Index = 6
        Me.MenuItem456.Text = "Senimandigital PHP Data Object Vue Bootstrap"
        '
        'MenuItem450
        '
        Me.MenuItem450.Index = 7
        Me.MenuItem450.Text = "Senimandigital PHP MySQL Procedural jQuery Spry"
        '
        'MenuItem451
        '
        Me.MenuItem451.Index = 8
        Me.MenuItem451.Text = "Senimandigital PHP MySQLi Procedural jQuery Bootstrap"
        '
        'MenuItem452
        '
        Me.MenuItem452.Index = 9
        Me.MenuItem452.Text = "Senimandigital PHP MySQLi Procedural Vue Bootstrap"
        '
        'MenuItem453
        '
        Me.MenuItem453.Index = 10
        Me.MenuItem453.Text = "Senimandigital PHP MySQLi Object jQuery Bootstrap"
        '
        'MenuItem454
        '
        Me.MenuItem454.Index = 11
        Me.MenuItem454.Text = "Senimandigital PHP MySQLi Object Vue Bootstrap"
        '
        'MenuItem445
        '
        Me.MenuItem445.Index = 12
        Me.MenuItem445.Text = "-"
        '
        'MenuItem405
        '
        Me.MenuItem405.Index = 13
        Me.MenuItem405.Text = "Github Repository Compare"
        '
        'MenuItem443
        '
        Me.MenuItem443.Index = 14
        Me.MenuItem443.Text = "CRUD PHP MySQLi Procedural"
        '
        'MenuItem442
        '
        Me.MenuItem442.Index = 15
        Me.MenuItem442.Text = "CRUD PHP Data Object"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 6
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem355, Me.MenuItem356, Me.MenuItem357, Me.MenuItem354, Me.MenuItem128, Me.MenuItem129, Me.MenuItem339, Me.MenuItem340, Me.MenuItem384, Me.MenuItem385, Me.MenuItem149})
        Me.MenuItem2.Text = "Project"
        '
        'MenuItem355
        '
        Me.MenuItem355.Index = 0
        Me.MenuItem355.Text = "Bugs"
        '
        'MenuItem356
        '
        Me.MenuItem356.Index = 1
        Me.MenuItem356.Text = "Job List"
        '
        'MenuItem357
        '
        Me.MenuItem357.Index = 2
        Me.MenuItem357.Text = "Request"
        '
        'MenuItem354
        '
        Me.MenuItem354.Index = 3
        Me.MenuItem354.Text = "-"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 4
        Me.MenuItem128.Text = "New Project"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 5
        Me.MenuItem129.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem341, Me.MenuItem342, Me.MenuItem147, Me.MenuItem148})
        Me.MenuItem129.Text = "Open Project"
        '
        'MenuItem341
        '
        Me.MenuItem341.Index = 0
        Me.MenuItem341.Text = "PhpMySource"
        '
        'MenuItem342
        '
        Me.MenuItem342.Index = 1
        Me.MenuItem342.Text = "VB.NETPHPJS"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 2
        Me.MenuItem147.Text = "-"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 3
        Me.MenuItem148.Text = "More Project"
        '
        'MenuItem339
        '
        Me.MenuItem339.Index = 6
        Me.MenuItem339.Text = "-"
        '
        'MenuItem340
        '
        Me.MenuItem340.Index = 7
        Me.MenuItem340.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem344, Me.MenuItem345, Me.MenuItem346, Me.MenuItem347, Me.MenuItem343, Me.MenuItem348, Me.MenuItem349, Me.MenuItem350})
        Me.MenuItem340.Text = "Costume Plugins"
        '
        'MenuItem344
        '
        Me.MenuItem344.Checked = True
        Me.MenuItem344.Index = 0
        Me.MenuItem344.Text = "Bootstrap"
        '
        'MenuItem345
        '
        Me.MenuItem345.Index = 1
        Me.MenuItem345.Text = "GoJS"
        '
        'MenuItem346
        '
        Me.MenuItem346.Checked = True
        Me.MenuItem346.Index = 2
        Me.MenuItem346.Text = "jQuery"
        '
        'MenuItem347
        '
        Me.MenuItem347.Index = 3
        Me.MenuItem347.Text = "MagicJS"
        '
        'MenuItem343
        '
        Me.MenuItem343.Checked = True
        Me.MenuItem343.Index = 4
        Me.MenuItem343.Text = "TinyMCE"
        '
        'MenuItem348
        '
        Me.MenuItem348.Index = 5
        Me.MenuItem348.Text = "-"
        '
        'MenuItem349
        '
        Me.MenuItem349.Index = 6
        Me.MenuItem349.Text = "More Plugins"
        '
        'MenuItem350
        '
        Me.MenuItem350.Index = 7
        Me.MenuItem350.Text = "Add Plugins"
        '
        'MenuItem384
        '
        Me.MenuItem384.Index = 8
        Me.MenuItem384.Text = "Manage Resource"
        '
        'MenuItem385
        '
        Me.MenuItem385.Index = 9
        Me.MenuItem385.Text = "-"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 10
        Me.MenuItem149.Text = "Properties"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 7
        Me.MenuItem4.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem98, Me.MenuItem257, Me.MenuItem383, Me.MenuItem94, Me.MenuItem95, Me.MenuItem7, Me.MenuItem170, Me.MenuItem171, Me.MenuItem172, Me.MenuItem15, Me.MenuItem23, Me.MenuItem258, Me.MenuItem97, Me.MenuItem25, Me.MenuItem24})
        Me.MenuItem4.Text = "Tool"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 0
        Me.MenuItem98.Text = "Manage Bookmark"
        '
        'MenuItem257
        '
        Me.MenuItem257.Index = 1
        Me.MenuItem257.Text = "Manage Design Translator"
        '
        'MenuItem383
        '
        Me.MenuItem383.Index = 2
        Me.MenuItem383.Text = "-"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 3
        Me.MenuItem94.Text = "New Behavior Backend"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 4
        Me.MenuItem95.Text = "New Behavior Frontend"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 5
        Me.MenuItem7.Text = "New Command"
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 6
        Me.MenuItem170.Text = "New Library"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 7
        Me.MenuItem171.Text = "New Snippet"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 8
        Me.MenuItem172.Text = "New Template"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 9
        Me.MenuItem15.Text = "New Window"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 10
        Me.MenuItem23.Text = "-"
        '
        'MenuItem258
        '
        Me.MenuItem258.Index = 11
        Me.MenuItem258.Text = "Manage Tool"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 12
        Me.MenuItem97.Text = "-"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 13
        Me.MenuItem25.Text = "More Tool"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 14
        Me.MenuItem24.Text = "Create New Tool"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 8
        Me.MenuItem5.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem154, Me.MenuItem155, Me.MenuItem156, Me.MenuItem157, Me.mainmenu_window_palette_database, Me.MenuItem159, Me.MenuItem160, Me.MenuItem161, Me.MenuItem162, Me.MenuItem163, Me.MenuItem164, Me.MenuItem166, Me.MenuItem259, Me.MenuItem260, Me.MenuItem165, Me.MenuItem167})
        Me.MenuItem5.Text = "Window"
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 0
        Me.MenuItem154.Text = "Code"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 1
        Me.MenuItem155.Text = "Design"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 2
        Me.MenuItem156.Text = "Diagram"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 3
        Me.MenuItem157.Text = "-"
        '
        'mainmenu_window_palette_database
        '
        Me.mainmenu_window_palette_database.Index = 4
        Me.mainmenu_window_palette_database.Text = "Database"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 5
        Me.MenuItem159.Text = "Binding"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 6
        Me.MenuItem160.Text = "Behavior Backend"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 7
        Me.MenuItem161.Text = "-"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 8
        Me.MenuItem162.Text = "Files"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 9
        Me.MenuItem163.Text = "Library"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 10
        Me.MenuItem164.Text = "Snippet"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 11
        Me.MenuItem166.Text = "-"
        '
        'MenuItem259
        '
        Me.MenuItem259.Checked = True
        Me.MenuItem259.Index = 12
        Me.MenuItem259.Text = "Toolbar"
        '
        'MenuItem260
        '
        Me.MenuItem260.Checked = True
        Me.MenuItem260.Index = 13
        Me.MenuItem260.Text = "Toolbox"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 14
        Me.MenuItem165.Text = "Object Properties"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 15
        Me.MenuItem167.Text = "Object Properties Full"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 9
        Me.MenuItem6.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem360, Me.MenuItem379, Me.MenuItem361, Me.MenuItem9, Me.MenuItem10, Me.MenuItem103, Me.MenuItem11, Me.MenuItem226, Me.MenuItem12, Me.MenuItem16, Me.MenuItem101, Me.MenuItem329, Me.MenuItem102, Me.MenuItem140, Me.MenuItem433, Me.MenuItem440, Me.MenuItem13, Me.MenuItem14})
        Me.MenuItem6.Text = "Help"
        '
        'MenuItem360
        '
        Me.MenuItem360.Index = 0
        Me.MenuItem360.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem364, Me.MenuItem365, Me.MenuItem374, Me.MenuItem375, Me.MenuItem376, Me.MenuItem362, Me.MenuItem363, Me.MenuItem377, Me.MenuItem378})
        Me.MenuItem360.Text = "Costume Tool"
        '
        'MenuItem364
        '
        Me.MenuItem364.Index = 0
        Me.MenuItem364.Text = "Default Browser"
        '
        'MenuItem365
        '
        Me.MenuItem365.Index = 1
        Me.MenuItem365.Text = "-"
        '
        'MenuItem374
        '
        Me.MenuItem374.Index = 2
        Me.MenuItem374.Text = "Behavior Backend Template"
        '
        'MenuItem375
        '
        Me.MenuItem375.Index = 3
        Me.MenuItem375.Text = "Behavior Frontend Template"
        '
        'MenuItem376
        '
        Me.MenuItem376.Index = 4
        Me.MenuItem376.Text = "-"
        '
        'MenuItem362
        '
        Me.MenuItem362.Index = 5
        Me.MenuItem362.Text = "Tag Editor"
        '
        'MenuItem363
        '
        Me.MenuItem363.Index = 6
        Me.MenuItem363.Text = "Translator Editor"
        '
        'MenuItem377
        '
        Me.MenuItem377.Index = 7
        Me.MenuItem377.Text = "-"
        '
        'MenuItem378
        '
        Me.MenuItem378.Index = 8
        Me.MenuItem378.Text = "More Cotume Tool "
        '
        'MenuItem379
        '
        Me.MenuItem379.Index = 1
        Me.MenuItem379.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem380, Me.MenuItem382, Me.MenuItem381})
        Me.MenuItem379.Text = "Database"
        '
        'MenuItem380
        '
        Me.MenuItem380.Index = 0
        Me.MenuItem380.Text = "Table Kurang"
        '
        'MenuItem382
        '
        Me.MenuItem382.Index = 1
        Me.MenuItem382.Text = "-"
        '
        'MenuItem381
        '
        Me.MenuItem381.Index = 2
        Me.MenuItem381.Text = "Field Kurang"
        '
        'MenuItem361
        '
        Me.MenuItem361.Index = 2
        Me.MenuItem361.Text = "-"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 3
        Me.MenuItem9.Text = "File"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 4
        Me.MenuItem10.Text = "Project"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 5
        Me.MenuItem103.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem104, Me.MenuItem472, Me.MenuItem123})
        Me.MenuItem103.Text = "Insert"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 0
        Me.MenuItem104.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem105, Me.MenuItem106, Me.MenuItem107, Me.MenuItem108, Me.MenuItem109, Me.MenuItem110, Me.MenuItem111, Me.MenuItem112, Me.MenuItem113, Me.MenuItem114, Me.MenuItem115, Me.MenuItem116, Me.MenuItem117, Me.MenuItem119, Me.MenuItem118, Me.MenuItem120, Me.MenuItem121, Me.MenuItem122})
        Me.MenuItem104.Text = "JQuery"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 0
        Me.MenuItem105.Text = "Accordion"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 1
        Me.MenuItem106.Text = "Autocomplete"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 2
        Me.MenuItem107.Text = "Button"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 3
        Me.MenuItem108.Text = "Checkboxradio"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 4
        Me.MenuItem109.Text = "Controlgroup"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 5
        Me.MenuItem110.Text = "Datepicker"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 6
        Me.MenuItem111.Text = "Dialog"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 7
        Me.MenuItem112.Text = "Draggable"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 8
        Me.MenuItem113.Text = "Droppable"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 9
        Me.MenuItem114.Text = "Menu"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 10
        Me.MenuItem115.Text = "Progressbar"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 11
        Me.MenuItem116.Text = "Selectable"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 12
        Me.MenuItem117.Text = "Selectmenu"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 13
        Me.MenuItem119.Text = "Slider"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 14
        Me.MenuItem118.Text = "Sortable"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 15
        Me.MenuItem120.Text = "Spinner"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 16
        Me.MenuItem121.Text = "Tabs"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 17
        Me.MenuItem122.Text = "Tooltip"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 2
        Me.MenuItem123.Text = "Vue"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 6
        Me.MenuItem11.Text = "Data"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 7
        Me.MenuItem226.Text = "Algoritma"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 8
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem150, Me.MenuItem152, Me.MenuItem153, Me.MenuItem151, Me.MenuItem224, Me.MenuItem225, Me.MenuItem223, Me.MenuItem99, Me.MenuItem177, Me.MenuItem178})
        Me.MenuItem12.Text = "Tool"
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 0
        Me.MenuItem150.Text = "Command"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 1
        Me.MenuItem152.Text = "Behavior Backend"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 2
        Me.MenuItem153.Text = "Behavior Frontend"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 3
        Me.MenuItem151.Text = "Library"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 4
        Me.MenuItem224.Text = "Snippet"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 5
        Me.MenuItem225.Text = "Template"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 6
        Me.MenuItem223.Text = "-"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 7
        Me.MenuItem99.Text = "Object Travel"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 8
        Me.MenuItem177.Text = "-"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 9
        Me.MenuItem178.Text = "Add New Help"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 9
        Me.MenuItem16.Text = "Window"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 10
        Me.MenuItem101.Text = "-"
        '
        'MenuItem329
        '
        Me.MenuItem329.Index = 11
        Me.MenuItem329.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem330, Me.MenuItem331, Me.MenuItem332, Me.MenuItem333, Me.MenuItem334})
        Me.MenuItem329.Text = "PhpMySource"
        '
        'MenuItem330
        '
        Me.MenuItem330.Index = 0
        Me.MenuItem330.Text = "Compare File"
        '
        'MenuItem331
        '
        Me.MenuItem331.Index = 1
        Me.MenuItem331.Text = "Compare Folder"
        '
        'MenuItem332
        '
        Me.MenuItem332.Index = 2
        Me.MenuItem332.Text = "-"
        '
        'MenuItem333
        '
        Me.MenuItem333.Index = 3
        Me.MenuItem333.Text = "More Tool"
        '
        'MenuItem334
        '
        Me.MenuItem334.Index = 4
        Me.MenuItem334.Text = "Add Tool"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 12
        Me.MenuItem102.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mainmenu_help_online_tool_google_searchconsole, Me.MenuItem173, Me.mainmenu_help_online_tool_speech_texter, Me.MenuItem174, Me.MenuItem175, Me.MenuItem176, Me.MenuItem181, Me.MenuItem182})
        Me.MenuItem102.Text = "Online Tool"
        '
        'mainmenu_help_online_tool_google_searchconsole
        '
        Me.mainmenu_help_online_tool_google_searchconsole.Index = 0
        Me.mainmenu_help_online_tool_google_searchconsole.Text = "Google Search Console"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 1
        Me.MenuItem173.Text = "Google Translate"
        '
        'mainmenu_help_online_tool_speech_texter
        '
        Me.mainmenu_help_online_tool_speech_texter.Index = 2
        Me.mainmenu_help_online_tool_speech_texter.Text = "Speech Texter"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 3
        Me.MenuItem174.Text = "-"
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 4
        Me.MenuItem175.Text = "Text To Form"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 5
        Me.MenuItem176.Text = "Text To Regex"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 6
        Me.MenuItem181.Text = "-"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 7
        Me.MenuItem182.Text = "Add Online Tool"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 13
        Me.MenuItem140.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem141, Me.MenuItem399, Me.MenuItem142, Me.MenuItem143, Me.MenuItem426, Me.MenuItem145, Me.MenuItem144, Me.MenuItem146, Me.MenuItem358, Me.MenuItem359})
        Me.MenuItem140.Text = "Plugins"
        '
        'MenuItem141
        '
        Me.MenuItem141.Checked = True
        Me.MenuItem141.Index = 0
        Me.MenuItem141.Text = "CodeMirror"
        '
        'MenuItem399
        '
        Me.MenuItem399.Checked = True
        Me.MenuItem399.Index = 1
        Me.MenuItem399.Text = "GoJS"
        '
        'MenuItem142
        '
        Me.MenuItem142.Checked = True
        Me.MenuItem142.Index = 2
        Me.MenuItem142.Text = "jQuery"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 3
        Me.MenuItem143.Text = "MagicJS"
        '
        'MenuItem426
        '
        Me.MenuItem426.Checked = True
        Me.MenuItem426.Index = 4
        Me.MenuItem426.Text = "Method Draw"
        '
        'MenuItem145
        '
        Me.MenuItem145.Checked = True
        Me.MenuItem145.Index = 5
        Me.MenuItem145.Text = "MxGraph"
        '
        'MenuItem144
        '
        Me.MenuItem144.Checked = True
        Me.MenuItem144.Index = 6
        Me.MenuItem144.Text = "TinyMCE"
        '
        'MenuItem146
        '
        Me.MenuItem146.Checked = True
        Me.MenuItem146.Index = 7
        Me.MenuItem146.Text = "JSTree"
        '
        'MenuItem358
        '
        Me.MenuItem358.Index = 8
        Me.MenuItem358.Text = "-"
        '
        'MenuItem359
        '
        Me.MenuItem359.Index = 9
        Me.MenuItem359.Text = "Add Plugins Help"
        '
        'MenuItem433
        '
        Me.MenuItem433.Index = 14
        Me.MenuItem433.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem434, Me.MenuItem435, Me.MenuItem437, Me.MenuItem436, Me.MenuItem438, Me.MenuItem439})
        Me.MenuItem433.Text = "Opensource"
        '
        'MenuItem434
        '
        Me.MenuItem434.Index = 0
        Me.MenuItem434.Text = "DB Browser fo SQLite"
        '
        'MenuItem435
        '
        Me.MenuItem435.Index = 1
        Me.MenuItem435.Text = "-"
        '
        'MenuItem437
        '
        Me.MenuItem437.Index = 2
        Me.MenuItem437.Text = "CRUD VB.NET"
        '
        'MenuItem436
        '
        Me.MenuItem436.Index = 3
        Me.MenuItem436.Text = "Notepad VB.NET"
        '
        'MenuItem438
        '
        Me.MenuItem438.Index = 4
        Me.MenuItem438.Text = "Plant VS Jombie VB.NET"
        '
        'MenuItem439
        '
        Me.MenuItem439.Index = 5
        Me.MenuItem439.Text = "UCanCode"
        '
        'MenuItem440
        '
        Me.MenuItem440.Index = 15
        Me.MenuItem440.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem441})
        Me.MenuItem440.Text = "Resource"
        '
        'MenuItem441
        '
        Me.MenuItem441.Index = 0
        Me.MenuItem441.Text = "MySQL"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 16
        Me.MenuItem13.Text = "-"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 17
        Me.MenuItem14.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem179, Me.MenuItem158, Me.MenuItem471, Me.MenuItem180, Me.MenuItem457})
        Me.MenuItem14.Text = "Tentang"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 0
        Me.MenuItem179.Text = "VB.NETPHPJS"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 1
        Me.MenuItem158.Text = "Github Compare"
        '
        'MenuItem471
        '
        Me.MenuItem471.Index = 2
        Me.MenuItem471.Text = "-"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 3
        Me.MenuItem180.Text = "Senimandigital"
        '
        'MenuItem457
        '
        Me.MenuItem457.Index = 4
        Me.MenuItem457.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem458, Me.MenuItem463, Me.MenuItem470})
        Me.MenuItem457.Text = "Dino Sukma Sarjito"
        '
        'MenuItem458
        '
        Me.MenuItem458.Index = 0
        Me.MenuItem458.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem459, Me.MenuItem460, Me.MenuItem461, Me.MenuItem462, Me.MenuItem469})
        Me.MenuItem458.Text = "Codepen"
        '
        'MenuItem459
        '
        Me.MenuItem459.Index = 0
        Me.MenuItem459.Text = "Project"
        '
        'MenuItem460
        '
        Me.MenuItem460.Index = 1
        Me.MenuItem460.Text = "-"
        '
        'MenuItem461
        '
        Me.MenuItem461.Index = 2
        Me.MenuItem461.Text = "Magic jQuery "
        '
        'MenuItem462
        '
        Me.MenuItem462.Index = 3
        Me.MenuItem462.Text = "Magic Vue"
        '
        'MenuItem469
        '
        Me.MenuItem469.Index = 4
        Me.MenuItem469.Text = "-"
        '
        'MenuItem463
        '
        Me.MenuItem463.Index = 1
        Me.MenuItem463.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem464, Me.MenuItem465, Me.MenuItem467, Me.MenuItem466, Me.MenuItem468})
        Me.MenuItem463.Text = "Github"
        '
        'MenuItem464
        '
        Me.MenuItem464.Index = 0
        Me.MenuItem464.Text = "htaphpjs"
        '
        'MenuItem465
        '
        Me.MenuItem465.Index = 1
        Me.MenuItem465.Text = "vbphpjs"
        '
        'MenuItem467
        '
        Me.MenuItem467.Index = 2
        Me.MenuItem467.Text = "vb.netphpjs"
        '
        'MenuItem466
        '
        Me.MenuItem466.Index = 3
        Me.MenuItem466.Text = "phpmysource"
        '
        'MenuItem468
        '
        Me.MenuItem468.Index = 4
        Me.MenuItem468.Text = "-"
        '
        'MenuItem470
        '
        Me.MenuItem470.Index = 2
        Me.MenuItem470.Text = "Sourceforge"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = -1
        Me.MenuItem33.Text = "New"
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = -1
        Me.MenuItem96.Text = "Preview In Browser"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = -1
        Me.MenuItem35.Text = "-"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = -1
        Me.MenuItem34.Text = "Exit"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = -1
        Me.MenuItem17.Text = "Add Content"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = -1
        Me.MenuItem90.Text = "Add Query"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = -1
        Me.MenuItem32.Text = "-"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = -1
        Me.MenuItem31.Text = "Properties"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = -1
        Me.MenuItem30.Text = "Snippet"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = -1
        Me.MenuItem93.Text = "Generate Master Page"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = -1
        Me.MenuItem18.Text = "Generate Form Insert"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = -1
        Me.MenuItem28.Text = "Generate Form Update"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = -1
        Me.MenuItem29.Text = "Generate Form Delete"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = -1
        Me.MenuItem26.Text = "-"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = -1
        Me.MenuItem27.Text = "Connect To Database"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = -1
        Me.MenuItem8.Text = "Command"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = -1
        Me.MenuItem92.Text = "Database"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = -1
        Me.MenuItem91.Text = "Project"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = -1
        Me.MenuItem20.Text = "-"
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = -1
        Me.MenuItem22.Text = "Manage Window"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = -1
        Me.MenuItem21.Text = "Add New Window"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = -1
        Me.MenuItem38.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem81, Me.MenuItem39, Me.MenuItem43, Me.MenuItem79})
        Me.MenuItem38.Text = "Form Generator"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 0
        Me.MenuItem81.Text = "Code Generator"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 1
        Me.MenuItem39.Text = "Modul Generator"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 2
        Me.MenuItem43.Text = "Page Generator"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 3
        Me.MenuItem79.Text = "-"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = -1
        Me.MenuItem82.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem80, Me.MenuItem78})
        Me.MenuItem82.Text = "Source Generator"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 0
        Me.MenuItem80.Text = "cURL Generator"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 1
        Me.MenuItem78.Text = "Regex Generator"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = -1
        Me.MenuItem42.Text = "-"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = -1
        Me.MenuItem45.Text = "Template Application"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = -1
        Me.MenuItem49.Text = "HTAPHPJS"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = -1
        Me.MenuItem86.Text = "JAVAPHPJS"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = -1
        Me.MenuItem47.Text = "VBPHPJS"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = -1
        Me.MenuItem48.Text = "VB.NETPHPJS"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = -1
        Me.MenuItem87.Text = "-"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = -1
        Me.MenuItem89.Text = "NodePHPJS"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = -1
        Me.MenuItem88.Text = "VuePHPJS"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = -1
        Me.MenuItem50.Text = "-"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = -1
        Me.MenuItem46.Text = "Browse Online"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = -1
        Me.MenuItem44.Text = "Template CMS"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = -1
        Me.MenuItem59.Text = "-"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = -1
        Me.MenuItem60.Text = "Dreamweaver PHP MySQL Spry"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = -1
        Me.MenuItem64.Text = "-"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = -1
        Me.MenuItem68.Text = "Senimandigital PHP Data Object JQuery"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = -1
        Me.MenuItem69.Text = "Senimandigital PHP Data Object Vue"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = -1
        Me.MenuItem70.Text = "Senimandigital PHP MySQLi Object JQuery"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = -1
        Me.MenuItem71.Text = "Senimandigital PHP MySQLi Object Vue"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = -1
        Me.MenuItem66.Text = "Senimandigital PHP MySQLi Procedural JQuery"
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = -1
        Me.MenuItem67.Text = "Senimandigital PHP MySQLi Procedural Vue"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = -1
        Me.MenuItem65.Text = "Senimandigital PHP MySQL JQuery"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = -1
        Me.MenuItem61.Text = "-"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = -1
        Me.MenuItem58.Text = "Browse Online"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = -1
        Me.MenuItem40.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem62, Me.MenuItem63, Me.MenuItem73, Me.MenuItem55, Me.MenuItem72})
        Me.MenuItem40.Text = "Template Database"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 0
        Me.MenuItem62.RadioCheck = True
        Me.MenuItem62.Text = "Senimandigital Simple"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 1
        Me.MenuItem63.Text = "Senimandigital Relational"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 2
        Me.MenuItem73.Text = "-"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 3
        Me.MenuItem55.Text = "Create Online"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 4
        Me.MenuItem72.Text = "Browse Online"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = -1
        Me.MenuItem41.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem74, Me.MenuItem75, Me.MenuItem83, Me.MenuItem84, Me.MenuItem85, Me.MenuItem76, Me.MenuItem77})
        Me.MenuItem41.Text = "Template Framework"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 0
        Me.MenuItem74.Text = "Codeigniter"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 1
        Me.MenuItem75.Text = "Laravel CRUDBooster"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 2
        Me.MenuItem83.Text = "Symphony OrangeHRM"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 3
        Me.MenuItem84.Text = "YII"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 4
        Me.MenuItem85.Text = "Zend"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 5
        Me.MenuItem76.Text = "-"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 6
        Me.MenuItem77.Text = "Browse Online"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = -1
        Me.MenuItem51.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem53, Me.MenuItem54, Me.MenuItem56, Me.MenuItem52, Me.MenuItem57})
        Me.MenuItem51.Text = "Template Tool"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 0
        Me.MenuItem53.Text = "PhpMyAdmin"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 1
        Me.MenuItem54.Text = "PhpMySource"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 2
        Me.MenuItem56.Text = "-"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 3
        Me.MenuItem52.Text = "Browse Online"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 4
        Me.MenuItem57.Text = "Browse Harddisk"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = -1
        Me.MenuItem100.Text = "Project"
        '
        'mainmenu_help_tentang
        '
        Me.mainmenu_help_tentang.Index = -1
        Me.mainmenu_help_tentang.Text = "VB.NETPHPJS"
        '
        'AxWebBrowser1
        '
        Me.AxWebBrowser1.Enabled = True
        Me.AxWebBrowser1.Location = New System.Drawing.Point(0, 0)
        Me.AxWebBrowser1.OcxState = CType(resources.GetObject("AxWebBrowser1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxWebBrowser1.Size = New System.Drawing.Size(1352, 696)
        Me.AxWebBrowser1.TabIndex = 0
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = -1
        Me.MenuItem36.Text = "PhpMyAdmin Table Designer"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = -1
        Me.MenuItem208.Text = "Master, Delete"
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = -1
        Me.MenuItem209.Text = "Master, Delete, Detail"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = -1
        Me.MenuItem210.Text = "Master, Delete, Insert, Update"
        '
        'MenuItem472
        '
        Me.MenuItem472.Index = 1
        Me.MenuItem472.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem473, Me.MenuItem474})
        Me.MenuItem472.Text = "jQuery Advance"
        '
        'MenuItem473
        '
        Me.MenuItem473.Index = 0
        Me.MenuItem473.Text = "Bind"
        '
        'MenuItem474
        '
        Me.MenuItem474.Index = 1
        Me.MenuItem474.Text = "Get"
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1384, 709)
        Me.Controls.Add(Me.AxWebBrowser1)
        Me.Menu = Me.MainMenu
        Me.Name = "Form1"
        Me.Text = "VB.NETPHPJS"
        CType(Me.AxWebBrowser1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim form_window_palette_toolbox As New window_palette_toolbox
        form_window_palette_toolbox.Show()

        Dim form_window_palette_database As New window_palette_database
        form_window_palette_database.Show()

        Dim form_window_palette_file As New window_palette_file
        form_window_palette_file.Show()

        Dim form_window_palette_code As New window_palette_code
        form_window_palette_code.Show()

        Dim window_palette_properties As New window_palette_properties
        window_palette_properties.Show()
        Me.Left = 135
        Me.Top = 0
        Me.Height = Screen.PrimaryScreen.Bounds.Height / 2 - 100
        Me.Width = Screen.PrimaryScreen.Bounds.Width - 300 - 135
        AxWebBrowser1.Navigate(Application.StartupPath & "/Templates/assets/TinyMCE/2.0.9/examples/word.html")
    End Sub
    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        AxWebBrowser1.Top = 0
        AxWebBrowser1.Left = 0
        AxWebBrowser1.Height = Me.Height
        AxWebBrowser1.Width = Me.Width
    End Sub
    Private Sub mainmenu_help_online_tool_google_searchconsole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainmenu_help_online_tool_google_searchconsole.Click
        AxWebBrowser1.Navigate("https://search.google.com/search-console/welcome")
    End Sub
    Private Sub mainmenu_help_online_tool_speech_texter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainmenu_help_online_tool_speech_texter.Click
        System.Diagnostics.Process.Start("https://www.speechtexter.com/")
    End Sub
    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        AxWebBrowser1.Navigate("https://codemirror.net/doc/manual.html#api")
    End Sub
    Private Sub MenuItem144_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem144.Click
        AxWebBrowser1.Navigate("https://www.tiny.cloud/docs-3x/api/class_tinyMCEPopup.html/")
    End Sub
    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        AxWebBrowser1.Navigate("https://api.jquery.com/")
    End Sub
    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        AxWebBrowser1.Navigate("https://www.jstree.com/api/")
    End Sub
    Private Sub MenuItem145_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem145.Click
        AxWebBrowser1.Navigate("https://jgraph.github.io/mxgraph/docs/js-api/files/index-txt.html")
    End Sub
    Private Sub MenuItem399_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem399.Click
        AxWebBrowser1.Navigate("https://gojs.net/latest/api/index.html")
    End Sub
    Private Sub mainmenu_window_palette_database_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mainmenu_window_palette_database.Click
        Dim form_window_palette_database As New window_palette_database
        form_window_palette_database.Show()
    End Sub
    Private Sub MenuItem158_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem158.Click
        AxWebBrowser1.Navigate("https://www.githubcompare.com/senimandigital/htaphpjs+senimandigital/vbphpjs+senimandigital/vb.netphpjs")
    End Sub
    Private Sub MenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem179.Click
        AxWebBrowser1.Navigate("https://github.com/senimandigital/VB.NETPHPJS")
    End Sub
    Private Sub MenuItem405_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem405.Click
        System.Diagnostics.Process.Start("https://www.githubcompare.com/senimandigital/htaphpjs+senimandigital/vbphpjs+senimandigital/vb.netphpjs")
    End Sub
    Private Sub MenuItem406_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem406.Click
        System.Diagnostics.Process.Start("https://codepen.io/css-tricks/pen/LufJE")
    End Sub
    Private Sub MenuItem409_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem409.Click
        System.Diagnostics.Process.Start("http://jsfiddle.net/vyder/7e0L7cuh/")
    End Sub
    Private Sub MenuItem410_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem410.Click
        System.Diagnostics.Process.Start("https://codepen.io/stromovyplh/pen/MqgwEX")
    End Sub
    Private Sub MenuItem411_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem411.Click
        System.Diagnostics.Process.Start("https://codepen.io/nguyenvu-the-selector/pen/aMqbem")
    End Sub
    Private Sub MenuItem426_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem426.Click
        System.Diagnostics.Process.Start("https://editor.method.ac/")
    End Sub
    Private Sub MenuItem428_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem428.Click
        System.Diagnostics.Process.Start("https://github.com/methodofaction/Method-Draw")
    End Sub
    Private Sub MenuItem429_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem429.Click
        System.Diagnostics.Process.Start("https://svg-edit.github.io/svgedit/")
    End Sub
    Private Sub MenuItem430_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem430.Click
        System.Diagnostics.Process.Start("https://github.com/projectstorm/react-diagrams")
    End Sub
    Private Sub MenuItem431_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem431.Click
        System.Diagnostics.Process.Start("http://fabricjs.com/")
    End Sub
    Private Sub MenuItem432_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem432.Click
        System.Diagnostics.Process.Start("http://www.draw2d.org/")
    End Sub
    Private Sub MenuItem434_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem434.Click
        System.Diagnostics.Process.Start("https://sqlitebrowser.org/")
    End Sub
    Private Sub MenuItem436_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem436.Click
        System.Diagnostics.Process.Start("https://code-projects.org/notepad-vb-net-source-code/")
    End Sub
    Private Sub MenuItem437_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem437.Click
        System.Diagnostics.Process.Start("https://code-projects.org/crud-application-vb-net-source-code/")
    End Sub
    Private Sub MenuItem438_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem438.Click
        System.Diagnostics.Process.Start("https://code-projects.org/plants-vs-zombies-game-vb-net-source-code/")
    End Sub
    Private Sub MenuItem439_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem439.Click
        System.Diagnostics.Process.Start("http://www.ucancode.net/index.htm")
    End Sub
    Private Sub MenuItem441_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem441.Click
        System.Diagnostics.Process.Start("https://dev.mysql.com/doc/")
    End Sub
    Private Sub MenuItem442_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem442.Click
        System.Diagnostics.Process.Start("https://mwoodruff.net/articles/projects/MySQLScripter/index.php")
    End Sub
    Private Sub MenuItem443_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem443.Click
        System.Diagnostics.Process.Start("http://www.phpcodebuilder.com/crud-generator/core-php-crud-generator.php")
    End Sub
    Private Sub MenuItem124_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem124.Click
        System.Diagnostics.Process.Start("https://www.homeandlearn.co.uk/NET/nets8p2.html")
    End Sub
    Private Sub MenuItem461_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem461.Click
        System.Diagnostics.Process.Start("https://codepen.io/senimandigital/projects/public")
    End Sub
    Private Sub MenuItem473_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem473.Click
        System.Diagnostics.Process.Start("https://api.jquery.com/bind/")
    End Sub
    Private Sub MenuItem474_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem474.Click
        System.Diagnostics.Process.Start("https://api.jquery.com/get/")
    End Sub
End Class
