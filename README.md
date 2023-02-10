# RageMP-InfoHud
This is a small script that adds some events to create info elements in player's screen.


# Infos come with:

- Fontawesome icons
- Info text
- Icon color and background color(RGBA)
- Background image



# Events:
```
/* client:createInfo
icon: fontawesome icon. e.g. : "fa-solid fa-user"
value: Info's text value.
color: Icon color. e.g. : "255, 255, 255"
backgroundColorRGBA: background color of info element with alpha value. e.g. : "255, 255, 255, 0.6"
image: image url of background
*/
```
```
client:createInfo(string icon, string value, string color, string backgroundColorRGBA, string image = "")
client:delInfo(string id)
client:setInfo(string id, string value)
client:showcefInfo(bool flag)
client:reloadInfo()
```
Info ids start from 1 and increase with each creation. Every id is unique and deleted info ids won't be used.


<p align="center">
  <img src="https://rage.mp/uploads/monthly_2023_02/Screenshot_1.png.972e824daf9350d5ab08326ab2a636da.png" />
</p>
