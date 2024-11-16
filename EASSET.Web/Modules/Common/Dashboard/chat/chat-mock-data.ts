import { ChatContact, ChatMessage } from "./chat-types";

export const contacts: ChatContact[] = [
    {
        name: "Vanessa Simons",
        avatar: "data:image/webp;base64,UklGRgYFAABXRUJQVlA4WAoAAAAIAAAAdwAAdwAAVlA4IAgEAABwHgCdASp4AHgAPq1Km0UjIjCXS9zpCwrE9IM4BnzAj1BU0HLSXtQ/Ydvcp+4lK9Sqb4c/5n8PTNkTPVW9v9pMt6LMrUgakDyhNU5sc/uu5iQbB881cYS/zs0/ZPq7XJ7NCLCk1S8VFYigR+2IYqquUKLsihJT2lZGUoOM8TBbkmiy8BXy3AFPto1YOGtd0FTvdLPmBQtMm7ysHQzTHjH4VAwirwaY4E/YL02lTNWgGChHFYAFteAliNrD33FvPP0+RMfUNuakz7PfTpCKaFYxDsL72iySBykOesUBlQOJOfNtc/KsflOFx9BDzRahikhEc8Xqiywr00i81gAA/voYTO009/szjj+sNO5fjEk7jmvyS9hjgDo4Yt1JFkaGbei36UtYUgnsEcDOrLixTxVe+X8mNb6alHTIIxnIePsISp/Aub55zjR6FAR61peBjl7d3g05qc8ot7813yE1eDwzCSM3YmMyDMVGbdCfwI11TukYEzN5uAAdCZzV7QhdHUSrHwlIxdEDDnkrTLIYHGU1oyHYQuBDnTxzSZu2F8ZuqP9aMv3BXCQirXPN6aAypopHvikXKm9RPi/QBQcjXX+hF/CeMUXsVTMWGuR+8TPYVnq4HIf0dgZAanjmY7RiTesax+Yw7AXRdOXNVG6mMGdSPcDYpCwB1E+kZvFO8E/KQXXIe9Al5bEtXsLBQauq3wp7rXdsj18fNgJGCdGrwVTM5cxFRhUB0tb/rqsVpPje4mhdgn7+/XzvT1JpBwrvrYMj8Z/CyMvWb0LlXtKGZXOYgSmpQpAhLXmlR3pMqNa1JPa97syzfoXoNabD36iHj7O+tI6TWbpXhYhUW5v1K4vyfrwihKmB4Byfnt29hsbXEAX730aIzLwt5R3T7MFfcZrQjHebckhZuRA1VKOuLcxxmmvt3WRJyYnVyDPQ0ZWrpCH7+al0mKigKzCEo+KFWGv1hBhThKfQXHd1Q3wWaeoddg9D5przblRzEt/z7SKmxv/frOCiW+7I0RIsq44nIBEI+Jy2+wnzLH5LNfFS2mrpOgIaGpxZP2TH6X0ryhlBeSV2k/D8iax2mt907omhE2/qN7+OGQfC5BfoRU1jSJ8h00hufRvOJ7rcQaoU4yfeFqQMxddg08k5BVw+Prg44+odXr1UT3I5sxv4koEiZglFm49HqEpaUQlCK5e6WXFe8m6LgeXsTe5wbsv534zaH+XRzQ6tqMHBgkX1ea1Q8ZI/vcpelsxFNy1N5lPwJRzl+peoJnBZiZfe8SjX9bHmCOaSWmpMFcOEQJEiLeGfxk6KPNF838zki4GigMb5aloyaff8VlhjrE8wws4V1G6G1/BTMGlEiyFobm+pmLTEQ5pMg8QBejwAAABFWElG2AAAAElJKgAIAAAABgASAQMAAQAAAAEAAAAaAQUAAQAAAFYAAAAbAQUAAQAAAF4AAAAoAQMAAQAAAAIAAAAxAQIAEQAAAGYAAABphwQAAQAAAHgAAAAAAAAASAAAAAEAAABIAAAAAQAAAHBhaW50Lm5ldCA0LjMuMTIAAAUAAJAHAAQAAAAwMjMwAaADAAEAAAABAAAAAqAEAAEAAAB4AAAAA6AEAAEAAAB4AAAABaAEAAEAAAC6AAAAAAAAAAIAAQACAAQAAABSOTgAAgAHAAQAAAAwMTAwAAAAAA==",
        online: true,
        unread: 2
    }, {
        name: "Chris Lessman",
        avatar: "data:image/webp;base64,UklGRloEAABXRUJQVlA4WAoAAAAIAAAAOwAAOwAAVlA4IFwDAABQEQCdASo8ADwAPq1InkgjIiEVCzUYMwrE4ArDNj0TDlZAeB6xx0Ki3nB7Sq8tDi8FMu/uUxhmuMPtXkrWG1m0UuUUCXyksCMEDdhzlIOdfxOBG5dGyVURkS1xmFJoRZg2w4Z2aHAuCEs3gOiT6V7g2nZdAEDj5/I7zw0zEZu/KSrokqw4wifZ+Qi1QHn/5unH2wAA/uDUnp8sm4Mj9y27eA2F7XZxNRZ30fyZH4J86Ml9Wv5Mw+nfGfKr+IlQDEyHxbfnKK7VJciXmrnNLV7dZgvZYE4MeQu6dMGimO0Off6ntF+pmXcBrrBG395qQ8ZEa+VhewK1Wq6kxg0gQk/EF5dskTJHHMHh7Wy2A70FW3QN8muzF7IwrUPpZFDJM/xKflPBzLv2Da3C5fg/3ufbTbW+VD7uYhjGIEVk9O7vOlnk7hKcmLrUldSvL4C/+0eKWCIqqjP1JmBwS40gcgIck7kHnr+PQX3TNfuqUI5/sOVf1c82aDyOnbFKu2IbuS9S2ze9HtoOjOBtoE9UGJWmuqtjwrgv1Qc+GBSOcXQmtsU421vmowhAoxj9Mkrdn8rgpd4BqKMjWQ7nb/Y2tLZOT1E8avAhbojEZCXdieYH5VSUCYdummxXttO5ddWTT3i0+D/MVVBea872TFaavYwcD1cX905dJj3OpU3TbCX6NxqDR+HHJ1qwBx6mYXFieB9g628CtrnWEWrn/ooM08kpE1eV3jtqJR71t2nbfg0J5Ph+ZWBuLfEvnKNFgjtC9DY57XtKknTRaJrDtddK+OkztCHAcfU+EG2D1+rLmzimzlqD5XmkpdAoXXjXExtuUxPYC2CJrDhZ2+QNY9kZkLJwWprzFvS4x2BIp0cdpRe6yStdbYv2pT6DlZ2KEaVsHL0XeFWJikRYhGiWPjTj3s2LbEzuqQAS+Usqx2T3sOLlvMERYBDqZ1ldsJBcc4A9rpvYS12GNZkX0mgLSDpBCtRFsGgf+/SFqt1+q96PnAt2h6QsLI1Wppnp4DKJweM0LZh9ANVyaJXJ1ecIi1c9lmg9T/tETaNG+PvQIYv4vtokdnL8wpcQ3QPC+x/6oglINLDymZnfd20MvOrE7VK8uB64Wm22P8Kp6+FizRoQ/LHljiJA+29LDQb/rRoAAEVYSUbYAAAASUkqAAgAAAAGABIBAwABAAAAAQAAABoBBQABAAAAVgAAABsBBQABAAAAXgAAACgBAwABAAAAAgAAADEBAgARAAAAZgAAAGmHBAABAAAAeAAAAAAAAABIAAAAAQAAAEgAAAABAAAAcGFpbnQubmV0IDQuMy4xMgAABQAAkAcABAAAADAyMzABoAMAAQAAAAEAAAACoAQAAQAAADwAAAADoAQAAQAAADwAAAAFoAQAAQAAALoAAAAAAAAAAgABAAIABAAAAFI5OAACAAcABAAAADAxMDAAAAAA",
        online: true
    }, {
        name: "Daniel Mason",
        avatar: "data:image/webp;base64,UklGRtQDAABXRUJQVlA4WAoAAAAIAAAAOwAAOwAAVlA4INYCAACQDgCdASo8ADwAPq1Em0UjIaEXDJVUMwrE4Axb/7yuvMfegXxu8R+gnFVhRjhhMpXLAWhL9mwf/7e8TQU47IA1DyI0b3MBTRDVI2Y7RUqDoVWs+68NaabhC4woW3cPw+N/yfI4YfciEgEUWw5RdTfqHm6OFLRV4gM3QOEGUAD+/73Oi5Z5hHx++gmxe7RDdv8zqEn9IveyarN+XyvPHd9qam0nAvA7IYNwQ4iqPPNMAMCtYWdeJE5SEqez7hEKM327qFATooF/UxGFqH/ZMr8mCmbZE2w3jHOrdMX5tvYFY+Uqakui3Gsp4fdXjjHO1sNj8b3b2FpwgbGJ86747r9doM/JpFUxNvHImd9OB+Tp7Gkj55p/Uce5fgkMyzXjaB7Y/8KQ+Fyv49rsv775PnCvwAXdW3vSuyPdi2BvuJD/Xus97vf/DJwX51cwIt0guJECKIQesfnXnZYja2tWb/PQlO8dkQP9YbQ+MoJV6HWU9b3dMLHO05GVTJnKF9cQMl5gx5AcnmIPjsp6VBI6JI7q7c598pyFi2t0aYt2fsIRX6cBXpxqwGrNB7gctW3Etujqvmen7k8cVqa8d/EYisc6vNFUrcDmakNW8Fd/+biIvpPZ1CgQeS/rt3L3MRBPJdPm79irKJTBBoMaYwmn2tJz9DZgkqL41716aTAiflR+gwlOqRHFk1KNM3BasOTWijSfzWx1+V/SvilEZeQF9ajvRruG/kiXmD2ftxZJHlRcmjIKMVVIZmTE1Op/uBr6WK/HpLvNUh8SwXZeYZYJ8MDnHRu+Cvl1RgpDb0g8NCM9b3SAuUQwj78T+ejfZd9IlVDO7GB6i7KUcpW9A8olmMY5AGMGnLIvg6tUveN0ZNYEAjVfU/UMt+60UEK6EsS55YEnkll/aKzPHRdkfLj4xjDYyFrWHdqP2rjtCj3JqtWz9C/kInOVeSU1qI6q/OxbKCXrtAAAAABFWElG2AAAAElJKgAIAAAABgASAQMAAQAAAAEAAAAaAQUAAQAAAFYAAAAbAQUAAQAAAF4AAAAoAQMAAQAAAAIAAAAxAQIAEQAAAGYAAABphwQAAQAAAHgAAAAAAAAAYAAAAAEAAABgAAAAAQAAAHBhaW50Lm5ldCA0LjMuMTIAAAUAAJAHAAQAAAAwMjMwAaADAAEAAAABAAAAAqAEAAEAAAA8AAAAA6AEAAEAAAA8AAAABaAEAAEAAAC6AAAAAAAAAAIAAQACAAQAAABSOTgAAgAHAAQAAAAwMTAwAAAAAA=="
    }, {
        name: "Fiona Green",
        avatar: "data:image/webp;base64,UklGRsAFAABXRUJQVlA4WAoAAAAYAAAAOwAAOwAAQUxQSNgBAAABkGzbtmk7e733Ytu2bdu2rZKdkm3bdkq2bdu2dfaKM+fKD0TEBDi0hIuWJFXymBHChzrrYckbj9149c2n93d3b5/fNX90MRSx3NwnXv/268E2CcSI5Fv5Tv/529keScVCuDb3FBpcHZyEF270R0UHp0oKKXTENyU+KiecBp+VejchJcoxJQ+jVP3AehyZILOV7SsQ4l6g6ZbwuMofeR+K4sarweGwsE0WNsPCb7NwPSZKVlp4nhHlZlj40hI21YKuCUVNNHEmGmqkiZsJUe1MvM6LKvLWgh8XAxT9qAX1s8NjZJS3oOfjYlzNzybOxgFlfWliTxTUExOzQjFJDgcWgqYOm++1WnyRHRTjjIkD0UCy2ILv59CVXhm4kgoWMs3TPrUTmEtyjXVqQCRH7BSQColjRphHyua42T78T2HTPcOzXOIblNyskP6eUYnl0t4laAda2GzGEJor/IKwRGihkzzuQNQQlot3APf19ZgQlst+E6Y6U2iu7HPcpgg8qfcS9iwnz0m1Wyjfx4CTPGdBejS2AefSnwR9aSsWYu8H6aEYBmIu9ah7KXiRpnpF+0GhLOn8RfFPMrDKvFZmZ+Ekv6LUm8UoETd4jj5uHIaT7l+U/Wl+kl8AVlA4IOICAABQDwCdASo8ADwAPqE8lUQjIaEXDJeMMwoE4NsAVIS7XxPy9vrzzLwANt3yJ+zZIZWU74amXPj+EAkvSu/hfJ6MVvyZrUIvjGb569+83o/F6n16BidW0bq1KS9U3ZY0T7/ktZyeWglgDb7n8twJmuB3ONDmxuQ4fbkLz2Y9eB1iB5J6gAD+9PwqlEiN80jNJ1Zi0lAxlrrnxeEKd0ocvLo+PUktOalPDF/IT/MJxJxD3Ac17SoYdJ3v76aKVrLjgi6rrEAYvfIelMIqYQ51K+u/dTo9Z/LDVRveELM0M0f6pdN548rAhRUuZAvAmHBQ1+d+XSeeS9Qjo7hKWG1ShVGyFemaSn+/MC0umdPXc+2i+yhim/joUEzda5KpfOuzsubqJrm8su7jAeQkBxSOqP6+uA79D62c4EGAJipOxSRvy8+lj7s/d3AKbSI6mJM4SkC3C1cFYEdMv6mv5q1pYvDr/clbZvcQI4X4k1jsA3ifp/pS5PAJ9tq9BN303bL5KUiBRueobIwqHmFV5wKDcTmnOtABQjJlfymQrzfsa/D8MjX7cBTfH34Sd4bFhZjAY6/kSKj+6nClWBwCVJI6KNuru287iKm92tvab4dcXy3K+ErGHfTEXZfQO4MgQebrJ5RB4VPf4C/QnGAls5N1aAdEqPsdaZPqrz22ZhRN3Nwr36TlXX4y/HZZKO8mzWd+wItZ+8uTqcypcBXTNUcQsj9Kwk3DijLEtDuc2TIvx7Y22iTfn11589soYY68L4nC1htHxH7ZgEeyNIOFtG2P//Rut5v/9MItp43vy7fx4GW0hllDZexOKV8jTlY7x6n/AjMc1Khz1H2aAS/DnnIqED2NBbFea1JPsD4FEUUUrxQJhZHDaKoBPLo5NmyJFX3XSRtyQ/NfjXG7+1Cp5v/FROUmM7c52DXDMihiX2xnc5Vne7mIWF3pE+b462dtuQveOe76m8peRTqWIQCOWkK/oyyAAABFWElG2AAAAElJKgAIAAAABgASAQMAAQAAAAEAAAAaAQUAAQAAAFYAAAAbAQUAAQAAAF4AAAAoAQMAAQAAAAIAAAAxAQIAEQAAAGYAAABphwQAAQAAAHgAAAAAAAAA8nYBAOgDAADydgEA6AMAAHBhaW50Lm5ldCA0LjMuMTIAAAUAAJAHAAQAAAAwMjMwAaADAAEAAAABAAAAAqAEAAEAAAA8AAAAA6AEAAEAAAA8AAAABaAEAAEAAAC6AAAAAAAAAAIAAQACAAQAAABSOTgAAgAHAAQAAAAwMTAwAAAAAA=="
    }, {
        name: "Dean Wilder",
        avatar: "data:image/webp;base64,UklGRjYFAABXRUJQVlA4WAoAAAAYAAAAOwAAOwAAQUxQSK4BAAABkHVtkyHJ2jMKs7Zt2zavbNu2cWXbtm3btm17u2cmY73xRURMgPlvcpocs/zf39bmJKPQCWlnWfRDY1LgxXrMws+zIOgPnp/XSvHJSIA/ku8XZfmeBHL8iN0Bn3OAvMb73gN4GoYqhTH0ggdxDzLWdidEvu8gfhEDMZrhjQHZP+POenKNGG9Li1FPBbyZxOZquBNZyj2jwbaU8q5r4CEkdU9FHyN1R0VTsZsq6otdV9FAyj2uor6Us0lFbSmaoaK82BANX5NImYYaLnli5a2CwK48MiGdZmhgnibT0rLO/jLVWGlhmRQBHR98Ge+xjgMkQ0t1jDHCBcNVNJByDmqwBaTMYA2fY4vlDlPwxBWjA7Ab4bOMfJ2AfQX5miCpDzCZKma3iAe+AUcOQxwlFH1ELDCwh4hmMHMGEEiG2wZYQzBaIhfIY/Aj5OYRjnrKdTD4+mFitgYuwg2WL4FrxPLhaWHp3gHCYqC8PQwMz4XqytDdLib9J0x4CYizisEXEwpFqdqjZ6OhFsVX68YU8Fs9YK3vFpUP+Y/kh1mzfTKxVBT6W8YbrN2+WNggDv0GVlA4IIICAADQDACdASo8ADwAPq1CnEgjIaEVCzV0MwrE4Av2w5j8EPLe8CXWlU01SKTvavxrq0zNGZJyjShExYDpzWw+tdZdD/6s2dl/jcHUOV2hwvZSTpwe9WM5OKfSLdj4suQNaKny3REjrl3oonIfCWrJGgAA/v98dR0dvmLaO0Q0zDGA7Rq1SO6cAv+GH0BGeEtTXysd7IHgeP0YYIv7M5QIvA/9//96rMTwlcv18yApwLRCI0IC+QgRkS1incn1QMorXhifiveM5lTgGHb1JzCDKyxcODi7s69Rc7lsj1YcvkrcEjyc6F7uIziv0OncYL8Knh24O3PEt3QT5p7YrVkGB9mGO0gl6PeS8qipu4/c69H4r70IVq/syZr+ckW1SgMPghUkdlfLfJ3WiIMp8LFgotYcE5peHG7N6LkpgjJR708uHluZR5CHVzpiPtVGXs6PEseTSK1IxlDlkVDV7ZAEqn6/tQSqwjdRAR49BvNbtga/Za4Y2fuah6SWlhP+IPYCntXSc0jnJgMoKVP93eMXQ0et5pHg4/JFaw1vySToYVsuav5Su0HSRpYfSOPn0Sz+6SIDz/8Gm1p312kzXUEHQXpt7rJ1YM7W9SzBo7x6bH6XRWK2nK0+FLBnPwqh0JzEAAP0LMJsINeGYeYZHbEo8PFGpF1reYOXGy//lLUkrBsKeftddNpGlsPpH3XmrtJUwDijAPVFD3mZ395yi9WOPBr1BZwtve10piBjZ8MI+obR2qqJ3CN0ZPL7sGHotEXY+8wbdR366KpSMeTzQ7Pz3MGkgmiWy+t65+qC9gYk5LBDpfkEpuX7I/Gkjokxd36Cvl4zNCNxLd8ai260u6h2ZhobAABFWElG2AAAAElJKgAIAAAABgASAQMAAQAAAAEAAAAaAQUAAQAAAFYAAAAbAQUAAQAAAF4AAAAoAQMAAQAAAAIAAAAxAQIAEQAAAGYAAABphwQAAQAAAHgAAAAAAAAA8nYBAOgDAADydgEA6AMAAHBhaW50Lm5ldCA0LjMuMTIAAAUAAJAHAAQAAAAwMjMwAaADAAEAAAABAAAAAqAEAAEAAAA8AAAAA6AEAAEAAAA8AAAABaAEAAEAAAC6AAAAAAAAAAIAAQACAAQAAABSOTgAAgAHAAQAAAAwMTAwAAAAAA=="
    }
]

export const otherContact = contacts[0];

export const ownContact = {
    name: "Mike Harris",
    avatar: "data:image/webp;base64,UklGRuIDAABXRUJQVlA4WAoAAAAIAAAAOwAAOwAAVlA4IOQCAABQDwCdASo8ADwAPq1Sn0sjIiERBVQzCsTxgGQ+oiw9hENTwd9pzCmNOjgqz1BLR5pRtM5X9YOF7kGpZtljj+6ckXFyW2KsgCc8JYL9KurrK3EdBBMrGowoK9UZD/iTA+KbXYnE1cbGvu3c+JR1unsTXPYnwH9HfTmvCZToLAPWx0ZgAAD+9cR7DIxrZnbJjXE9lU58QYGFwJDpLWxoJ9rsw2loZFnhgjbjtYOK3RXspHa3War4aN+9zdH0d/yLDZ1++f3K7CMaYccYamwlYy3zOPreZxAaab+65YP2bdRK3aI2Ko/BYZHGHwSWPwMfoUnSLwB7Vt4QW/Drh6A6riCahnxfEl3vXACxlbbrKrc1A0vx2csOmv9K3bp2kJ/824w3f7S90Capou4AQB55p9QsJvQuSgk9IUJ/EySModtebrq1s+6GnSHo2tD6hXhVUUDhcvPdqIcjDapEej3Ifd7nN0XWDgRS+Cw1ze0STx2SohhMOpase21zKkfN08WMhQOFY9ZVwNrebUumtW0Va9UsqrZ6rGm6zCTkvllrSAQazUYH3OufacPWpBf5zo7I7Bf6hydXU2uCT5ZHlggyb88Smj5JLnIK/Qw/Qplnzkc8tEPmAVryyVAHJuGnLfjOKV6q/aBhmsxewLvKnAV35/cd2fhEsrct+flzIi99uoZ8MYMbGbKsvggeUckP79DhSk6uVyJbbNCTiGJrIwK1OCPtx5k/kI/RCX5iWmQNi5PvtKfh2GMxJn8kW+7SyRfgV+wHqnpAjqRyrYRWOqlbUFStsEzS6qie6dw5vz78c9Oyp3lDvjL1oAaBxHQafb4gdEOyhMV+Aot/W7MNXTA2jv0dK596U+n53w3BvhCP7HnUoZJ8dmyQOG44aHxyFsAGOzspba9AjjtTVadQlA55iLdUwXGxFkkt4kqIS97R8ZFo2zr/o51JN5J5MTffdtVBQmWBgYdBhaMmwiI/Jw3THMJyETAAAEVYSUbYAAAASUkqAAgAAAAGABIBAwABAAAAAQAAABoBBQABAAAAVgAAABsBBQABAAAAXgAAACgBAwABAAAAAgAAADEBAgARAAAAZgAAAGmHBAABAAAAeAAAAAAAAABgAAAAAQAAAGAAAAABAAAAcGFpbnQubmV0IDQuMy4xMgAABQAAkAcABAAAADAyMzABoAMAAQAAAAEAAAACoAQAAQAAADwAAAADoAQAAQAAADwAAAAFoAQAAQAAALoAAAAAAAAAAgABAAIABAAAAFI5OAACAAcABAAAADAxMDAAAAAA"
}

export const messageList: ChatMessage[] = [
    {
        contact: ownContact,
        time: "2:33 pm",
        message: "Lorem ipsum dolor sit amet, vis erat denique in, dicunt prodesset te vix."
    }, {
        contact: otherContact,
        time: "2:34 pm",
        message: "Sit meis deleniti eu, pri vidit meliore docendi ut, an eum erat animal commodo."
    }, {
        contact: ownContact,
        time: "2:37 pm",
        message: "Cum ea graeci tractatos.",
    }, {
        contact: otherContact,
        time: "2:38 pm",
        message: "Sed pulvinar, massa vitae interdum pulvinar, risus lectus porttitor magna, vitae commodo lectus mauris et velit. Proin ultricies placerat imperdiet. Morbi varius quam ac venenatis tempus.",
    }, {
        contact: otherContact,
        time: "2:40 pm",
        message: "Cras pulvinar, sapien id vehicula aliquet, diam velit elementum orci."
    }, {
        contact: ownContact,
        time: "2:41 pm",
        message: "Lorem ipsum dolor sit amet, vis erat denique in, dicunt prodesset te vix."
    }, {
        contact: otherContact,
        time: "2:41 pm",
        message: "Sit meis deleniti eu, pri vidit meliore docendi ut, an eum erat animal commodo."
    }, {
        contact: ownContact,
        time: "2:42 pm",
        message: "Cum ea graeci tractatos."
    }
]