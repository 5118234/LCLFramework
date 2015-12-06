(function () {
    $.extend($.fn, {
        LoadingMask: function (languageType, msg, maskDivClass, fixHeight, isNullPosition) {
            ///	<summary>
            /// ������ʾ��
            /// </summary>
            /// <param name="languageType" type="String">�������ͣ�2052���� 1033Ӣ��</param>
            /// <param name="msg" type="String">��Ϣ����</param>
            /// <param name="maskDivClass" type="String">������Ϣ��ʽ</param>
            /// <param name="fixHeight" type="Int">���ǲ�����߶�</param>
            /// <param name="isNullPosition" type="bool">�Ƿ���Ҫƫ��λ�ã�һ�����ڸ���������λ���ϣ�������ֵ����ҪΪ��top:0,left:0</param>
            /// <returns type="���ؼ�����ʾ��" />
            this.UnLoadingMask();
            // ����
            var op = {
                opacity: 0.8,
                z: 10000,
                bgcolor: '#ccc'
            };
            var original = $(document.body);
            var position = { top: 0, left: 0 };
            if (this[0] && this[0] !== window.document) {
                original = this;
                if (isNullPosition != "" && isNullPosition != undefined) {
                    position = { top: 0, left: 0 };
                } else {
                    position = original.position();
                }
            }
            // ����һ�� Mask �㣬׷�ӵ�������
            var maskDiv = $('<div class="maskdivgen">&nbsp;</div>');
            maskDiv.appendTo(original);
            var maskWidth = original.outerWidth();
            if (!maskWidth) {
                maskWidth = original.width();
            }
            var maskHeight = original.outerHeight();
            if (!maskHeight) {
                maskHeight = original.height() - 20;
            }
            if (fixHeight) {
                maskHeight = maskHeight - fixHeight;
            }
            maskDiv.css({
                position: 'absolute',
                top: position.top,
                left: position.left,
                'z-index': op.z,
                width: maskWidth,
                height: maskHeight,
                'background-color': op.bgcolor,
                opacity: 0
            });
            if (maskDivClass) {
                maskDiv.addClass(maskDivClass);
            } else {
                var message = "";
                if (msg == "" || msg == undefined) {
                    if (languageType == "" || languageType == undefined) {
                        languageType = "2052";
                    }
                    if (languageType == "2052") {
                        message = "�����У����Ժ�...";
                    } else if (languageType == "1033") {
                        message = "Loading��Please Waiting...";
                    }
                } else {
                    message = msg;
                }
                var msgDiv = $('<div class="LodingDiv"><div class="LoadContext"><div class="LoadImg"></div><div id="Load_Message">' + message + '</div></div></div>');
                msgDiv.appendTo(maskDiv);
                var widthspace = (maskDiv.width() - msgDiv.width());
                var heightspace = (maskDiv.height() - msgDiv.height());
                msgDiv.css({
                    cursor: 'wait',
                    top: (heightspace / 2 - 2),
                    left: (widthspace / 2 - 2)
                });
            }
            maskDiv.fadeIn('fast', function () {
                // ���뵭��Ч��
                $(this).fadeTo(200, op.opacity);
            })
            return maskDiv;
        },
        DisplayBuildData: function (languageType) {
            ///	<summary>
            /// ��ʾ���ڹ���
            /// </summary>
            /// <param name="languageType" type="String">�������ͣ�zh-cn���� enӢ��</param>
            /// <returns type="���ؼ�����ʾ��" />
            var msg = "";
            if (languageType == "2052") {
                msg = "���ڹ���,���Ժ�...";
            } else if (languageType == "1033") {
                msg = "Building Now,Please Waiting...";
            }
            $("#Load_Message").html(msg);
        },
        UnLoadingMask: function () {
            ///	<summary>
            /// ȡ����ʾ��
            /// </summary>
            /// <returns type="ȡ��������ʾ��" />
            var original = $(document.body);
            if (this[0] && this[0] !== window.document) {
                original = $(this[0]);
            }
            original.find("> div.maskdivgen").fadeOut(50, 0, function () {
                $(this).remove();
            });
        },
        getUrlParam : function (name) {
            var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)");
            var r = window.location.search.substr(1).match(reg);
            if (r != null) return unescape(r[2]); return null;
        }
    });
})();
//��ȡurl�еĲ���
function getUrlParam(name) {
    var reg = new RegExp("(^|&)" + name + "=([^&]*)(&|$)"); //����һ������Ŀ�������������ʽ����
    var r = window.location.search.substr(1).match(reg);  //ƥ��Ŀ�����
    if (r != null) return unescape(r[2]); return null; //���ز���ֵ
}