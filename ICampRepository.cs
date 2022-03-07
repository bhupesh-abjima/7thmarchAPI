using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TheCodeCamp.Data
{
  public interface ICampRepository
  {
        Task<bool> SaveChangesAsync();

  
    void AddCamp(Camp camp);
    void DeleteCamp(Camp camp);
    Task<Camp[]> GetAllCampsAsync(bool includeTalks = false);
    Task<Camp> GetCampAsync(string moniker, bool includeTalks = false);
    Task<Camp[]> GetAllCampsByEventDate(DateTime dateTime, bool includeTalks = false);

   
    void AddTalk(Talk talk);
    void DeleteTalk(Talk talk);
    Task<Talk> GetTalkByMonikerAsync(string moniker, int talkId, bool includeSpeakers = false);
    Task<Talk[]> GetTalksByMonikerAsync(string moniker, bool includeSpeakers = false);

   
    void AddSpeaker(Speaker speaker);
    void DeleteSpeaker(Speaker speaker);
    Task<Speaker[]> GetSpeakersByMonikerAsync(string moniker);
    Task<Speaker> GetSpeakerAsync(int speakerId);
    Task<Speaker[]> GetAllSpeakersAsync();

  }
}