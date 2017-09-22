using System;
using System.Collections.Generic;

using Vk.Api.Schema.Enums;
using Vk.Api.Schema.Enums.Group;

namespace Vk.Api.Schema.Common.Group
{
    /// <summary>
    /// ��������� ��� ������������� ���������� � ���������� "���������"<para/>
    /// ������������: <see href="https://vk.com/dev/objects/group">objects.group</see>
    /// </summary>
    public interface IGroup
    {
        /// <summary>
        /// ������������� ����������
        /// </summary>
        int Id { get; }

        /// <summary>
        /// �������� ����������
        /// </summary>
        string Name { get; }

        /// <summary>
        /// �������� ����� ����������
        /// </summary>
        string ScreenName { get; }

        /// <summary>
        /// ��� ���������� (��������, �������� ��� �������)
        /// </summary>
        GroupClosedType Closed { get; }

        /// <summary>
        /// ������ ���������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        BlockStatus? BlockStatus { get; }

        /// <summary>
        /// �������� �� ������� ������������ �������������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? IsAdmin { get; }

        /// <summary>
        /// ������� ���������� ������������ � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        AdminLevel? Level { get; }

        /// <summary>
        /// �������� �� ������������ ���������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? IsMember { get; }

        /// <summary>
        /// ������������� ������������, ������� �������� ����������� � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        int? InvitedBy { get; }

        /// <summary>
        /// ��� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        GroupType? Type { get; }

        /// <summary>
        /// ������ ��������� ��������� ��������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        string Activity { get; }

        /// <summary>
        /// ���������� �����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        AgeLimits? Limits { get; }

        /// <summary>
        /// ���������� � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        IBanInfo BanInfo { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������ ����� ������� ���������� � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? CanCreateTopic { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������ ����� ��������� ��������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? CanMessage { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������ ����� ��������� ������ �� ����� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? CanPost { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������ ����� ������ ����� ������ �� ����� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? CanSeeAllPosts { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������ ����� ��������� ��������� � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? CanUploadDocument { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������ ����� ��������� ����������� � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? CanUploadVideo { get; }

        /// <summary>
        /// �����, ��������� � ���������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        ICity City { get; }

        /// <summary>
        /// �������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        IEnumerable<IContact> Contacts { get; }

        /// <summary>
        /// �������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        ICounters Counters { get; }

        /// <summary>
        /// ���������� � ������ ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        ICountry Country { get; }

        /// <summary>
        /// �������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        string Description { get; }
        
        /// <summary>
        /// ������� ����������
        /// </summary>
        ICover Cover { get; }

        /// <summary>
        /// ������������� ������������ ������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        int? FixedPost { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ����������� ������� ���������� ����������
        /// </summary>
        bool? HasPhoto { get; }

        /// <summary>
        /// <see langword="true" />, ���� ���������� ��������� � ��������� � ������������
        /// </summary>
        bool? IsFavorite { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ��������� ������ �� �������� �������� ������������
        /// </summary>
        bool? IsHiddenFromFeed { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ������������� ��������� �� ����� ���������� � ������������
        /// </summary>
        bool? IsMessagesBlocked { get; }

        /// <summary>
        /// ��������� ������ �� ����� ������ ����������
        /// </summary>
        IEnumerable<ILink> Links { get; }

        /// <summary>
        /// ������������� ��������� �����������, ���� ��������,
        /// ����� <see langword="null"/> 
        /// </summary>
        int? MainAlbumId { get; }

        /// <summary>
        /// ���������� � ������� ������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        SectionType? MainSection { get; }

        /// <summary>
        /// ���������� � ��������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        IMarketInfo Market { get; }

        /// <summary>
        /// ������ ��������� �������� ������������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        MemberStatus? MemberStatus { get; }

        /// <summary>
        /// ���������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        int? MembersCount { get; }

        /// <summary>
        /// �����, ��������� � ���������� � ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        IPlace Place { get; }

        /// <summary>
        /// ����� �������� <see cref="StartDate"/>, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        string PublicDateLabel { get; }

        /// <summary>
        /// ����� ����� � �������� ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        Uri Url { get; }

        /// <summary>
        /// ���� ��������� (��� ��������) ��� ���� ������� (��� �������), ���� ��������,
        /// ����� <see langword="null"/> 
        /// </summary>
        DateTime? StartDate { get; }

        /// <summary>
        /// ���� ��������� (��� �������), ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        DateTime? FinishDate { get; }

        /// <summary>
        /// ������ ����������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        string Status { get; }

        /// <summary>
        /// <see langword="true"/>, ���� ���������� ���������������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        bool? IsVerified { get; }

        /// <summary>
        /// �������� ������� ����-��������, ���� ��������,
        /// ����� <see langword="null"/>
        /// </summary>
        string WikiPage { get; }
        
    }
}