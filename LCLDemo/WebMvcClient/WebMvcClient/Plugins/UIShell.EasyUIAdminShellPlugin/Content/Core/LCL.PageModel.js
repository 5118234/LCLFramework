/// <summary>
/// �ű��������-ҳ��ģ��
/// </summary>
$.LCLPageModel = {
    Resource: {
        Language: { zh_CN: "2052", en_US: "1033" }, // ���Ա���
        LanguageResourceInfo: [], // ����������Դ
        PageLanguageResource: [], // ҳ��������Դ
        CommonLanguageResource: [], // ����������Դ
        InitLanguageResource: null, // ��ʼ���ؼ�����ķ��� �÷�����ҳ��ű���ʵ��
        InitLanguage: function () {
            //ҳ�����õĶ��������
            this.InitLanguageResource();
            //ԭ�еĶ��������
            var languageInfo = [];
            languageInfo[this.Language.zh_CN] = {
                validateMsg: "��©���˱���������롣",
                queryModelSearching: "���ڲ�ѯ"
            };
            languageInfo[this.Language.en_US] = {
                validateMsg: "Some values are empty,please fill it.",
                queryModelSearching: "Searching"
            };
            // ��������id���õ�ǰ������Դ
            this.CommonLanguageResource = languageInfo[pageAttr.LanguageId];
        }
    },
    /// <summary>
    /// �ű��������-ҳ��ģ��-�������
    /// </summary>
    PageCommand: {
        GetPageAllControlToJSON: function () {
            /// <summary>
            /// �÷���ϵͳ�ᶯ̬����
            /// </summary>
        },
        SetJSONToPageAllControl: function () {
            /// <summary>
            /// �÷���ϵͳ�ᶯ̬����
            /// </summary>
        }
    }
};